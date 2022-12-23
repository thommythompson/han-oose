using HAN.ICDETool.Core.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;

namespace HAN.ICDETool.Infrastructure.Data;

public class EntityFrameworkDbActions : DbActions
{
    private readonly ICDEContext _dbContext;
    private readonly ILogger<DbActions> _logger;
    private readonly UserManager<Persoon> _userManager;
    private readonly RoleManager<IdentityRole<int>> _roleManager;

    public EntityFrameworkDbActions(ICDEContext dbContext, ILogger<DbActions> logger, UserManager<Persoon> userManager, RoleManager<IdentityRole<int>> roleManager)
    {
        _dbContext = dbContext;
        _logger = logger;
        _userManager = userManager;
        _roleManager = roleManager;
    }
    
    public async Task SeedIfDatabaseEmpty()
    {
        if (!_dbContext.CourseInrichting.Any())
        {
            await Seed();
        }
        else
        {
            _logger.LogInformation("Database already contains data, skipping seeding");
        }
    }

    private async Task Seed()
    {
        _logger.LogInformation("Start seeding database");

        if (!await _roleManager.RoleExistsAsync("Docent"))
        {
            await _roleManager.CreateAsync(new IdentityRole<int>("Docent"));
        }
        Persoon docent1 = await _userManager.FindByEmailAsync("docent1@han.nl");
        if(docent1 == null)
        {
            _logger.LogInformation("Seeding docent1@han.nl user");

            docent1 = new Persoon("Docent", "1", "docent1@han.nl");
            var result = await _userManager.CreateAsync(docent1, "P@ssw0rd");
            if(result != IdentityResult.Success)
            {
                throw new InvalidOperationException("Kon docent1@han.nl niet registeren tijdens het seeden.");
            }

            await _userManager.AddToRoleAsync(docent1, "Docent");
            await _userManager.UpdateAsync(docent1);
        }

        if (!await _roleManager.RoleExistsAsync("Student"))
        {
            await _roleManager.CreateAsync(new IdentityRole<int>("Student"));
        }
        Persoon student1 = await _userManager.FindByEmailAsync("student1@han.nl");
        if(student1 == null)
        {
            _logger.LogInformation("Seeding student1@han.nl user");

            student1 = new Persoon("Student", "1", "student1@han.nl");
            var result = await _userManager.CreateAsync(student1, "P@ssw0rd");
            if(result != IdentityResult.Success)
            {
                throw new InvalidOperationException("Kon student1@han.nl niet registeren tijdens het seeden.");
            }
            
            await _userManager.AddToRoleAsync(student1, "Student");
            await _userManager.UpdateAsync(student1);
        }
        
        CourseInrichting courseInrichting = new CourseInrichting("titeldo", "omschrijving", docent1);
        _dbContext.CourseInrichting.Add(courseInrichting);
        _dbContext.SaveChanges();
        
        EenheidVanLeeruitkomsten eenheidVanLeeruitkomsten = new EenheidVanLeeruitkomsten("titel", "omschrijving");
        Leeruitkomst leeruitkomst = new Leeruitkomst("titel","omschrijving");
        Leerdoel leerdoel = new Leerdoel("titel", "omschrivjing");
        leeruitkomst.KoppelLeerdoel(leerdoel);
        eenheidVanLeeruitkomsten.AddLeeruitkomst(leeruitkomst);
        courseInrichting.AddEenheidVanLeeruitkomsten(eenheidVanLeeruitkomsten);
        courseInrichting.AddToets(new SchriftelijkeToets("titel", leerdoel));
        _dbContext.EenheidVanLeeruitkomsten.Add(eenheidVanLeeruitkomsten);
        _dbContext.SaveChanges();
        
        courseInrichting.CreatePlanning(new Semester());

        LesInrichting lesInrichting = new LesInrichting("Titel", leerdoel);
        lesInrichting.AddLesMateriaal(new LesMateriaal());
        courseInrichting.AddLes(lesInrichting);
        _dbContext.LesInrichting.Add(lesInrichting);
        _dbContext.SaveChanges();
        
        BeroepsProduct beroepsProduct = new BeroepsProduct("BP Titel");
        Rubric rubric1 = new Rubric("Rubric1", leerdoel);
        for (int i = 0; i < 5; i++)
        {
            rubric1.AddBeoordelingsCriteria(new BeoordelingsCriteria("blabla"));
        }
        Rubric rubric2 = new Rubric("Rubric2", leerdoel);
        for (int i = 0; i < 5; i++)
        {
            rubric2.AddBeoordelingsCriteria(new BeoordelingsCriteria("blabla"));
        }
        beroepsProduct.AddRubric(rubric1);
        beroepsProduct.AddRubric(rubric2);
        courseInrichting.AddBeroepsProduct(beroepsProduct);
        _dbContext.BeroepsProduct.Add(beroepsProduct);
        _dbContext.SaveChanges();
        
        SchriftelijkeToets schriftelijkeToets = new SchriftelijkeToets("titel", leerdoel);
        courseInrichting.AddToets(schriftelijkeToets);
        _dbContext.SchriftelijkeToets.Add(schriftelijkeToets);
        _dbContext.SaveChanges();
        
        CourseWeekInrichting courseWeekInrichting = courseInrichting.Planning.Weken.First();
        courseWeekInrichting.AddLes(lesInrichting);
        courseWeekInrichting.AddBeroepsProduct(beroepsProduct);
        courseWeekInrichting.AddToets(schriftelijkeToets);
        _dbContext.CourseWeekInrichting.Update(courseWeekInrichting);
        _dbContext.SaveChanges();
        
        courseInrichting.MaakDefintief();
        CourseUitvoering courseUitvoering = courseInrichting.StartCourseUitvoering(new DateTimeOffset(DateTime.Now));
        _dbContext.CourseUitvoering.Add(courseUitvoering);
        _dbContext.SaveChanges();

        Locatie locatie = new Locatie("Locatie naam", LocatieType.Fysiek);
        locatie.Adres = new Adres("Straatnaam", "1", "9999LA", "Arnhem");
        _dbContext.Locatie.Add(locatie);
        _dbContext.SaveChanges();
        
        
        Opleiding opleiding = new Opleiding("ICT", "han-hbo-ict");
        OpleidingsProfiel opleidingsProfiel = new OpleidingsProfiel("Software Development", "sd");
        opleiding.AddOpleidingsProfiel(opleidingsProfiel);
        student1.VolgtProfiel = opleidingsProfiel;
        _dbContext.Opleiding.Add(opleiding);
        _dbContext.SaveChanges();
        
        Klas klas = new Klas("hbo-ict-2bhj");
        klas.AddStudent(student1);
        klas.DocentId = docent1.Id;
        _dbContext.Klas.Add(klas);
        _dbContext.SaveChanges();
        
        TentamenUitvoering tentamenUitvoering = courseUitvoering.Weken.First().Tentamen.First();
        _dbContext.Beoordeling.Add(new Beoordeling(tentamenUitvoering, student1, docent1)) ;
        _dbContext.SaveChanges();
    }

    public void CreateDatabaseIfNotExists()
    {
        _logger.LogInformation("Ensuring database does exist");
        
        _dbContext.Database.EnsureCreated();
    }
}