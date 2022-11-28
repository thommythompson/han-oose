using HAN.ICDETool.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace HAN.ICDETool.Infrastructure.Data;

public class EntityFrameworkDbActions : DbActions
{
    private readonly ICDEContext _dbContext;
    private readonly ILogger<DbActions> _logger;

    public EntityFrameworkDbActions(ICDEContext dbContext, ILogger<DbActions> logger)
    {
        _dbContext = dbContext;
        _logger = logger;
    }
    
    public override void SeedIfDatabaseEmpty()
    {
        if (!_dbContext.CourseInrichting.Any())
        {
            Seed();
        }
        else
        {
            _logger.LogInformation("Database already contains data, skipping seeding");
        }
    }

    private void Seed()
    {
        _logger.LogInformation("Start seeding database");
        
        Docent docent = new Docent("docent", "achternaam", "d.achternaam@example.com");
        _dbContext.Docent.Add(docent);
        _dbContext.SaveChanges();
        
        CourseInrichting courseInrichting = new CourseInrichting("titeldo", "omschrijving", docent);
        _dbContext.CourseInrichting.Add(courseInrichting);
        _dbContext.SaveChanges();
        
        EenheidVanLeeruitkomsten eenheidVanLeeruitkomsten = new EenheidVanLeeruitkomsten("titel", "omschrijving");
        Leeruitkomst leeruitkomst = new Leeruitkomst("titel","omschrijving");
        Leerdoel leerdoel = new Leerdoel("titel", "omschrivjing");
        leeruitkomst.KoppelLeerdoel(leerdoel);
        eenheidVanLeeruitkomsten.AddLeeruitkomst(leeruitkomst);
        courseInrichting.AddEenheidVanLeeruitkomsten(eenheidVanLeeruitkomsten);
        courseInrichting.AddToets(new SchriftelijkeToets("titel", leerdoel));
        _dbContext.CourseInrichting.Add(courseInrichting);
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
        courseInrichting = _dbContext.CourseInrichting.First();
        courseInrichting.AddBeroepsProduct(beroepsProduct);
        _dbContext.BeroepsProduct.Add(beroepsProduct);
        _dbContext.SaveChanges();
        
        SchriftelijkeToets schriftelijkeToets = new SchriftelijkeToets("titel", leerdoel);
        courseInrichting = _dbContext.CourseInrichting.First();
        courseInrichting.AddToets(schriftelijkeToets);
        _dbContext.SchriftelijkeToets.Add(schriftelijkeToets);
        _dbContext.SaveChanges();
        
        CourseWeekInrichting courseWeekInrichting = courseInrichting.Planning.Weken.First();
        courseWeekInrichting.AddLes(lesInrichting);
        courseWeekInrichting.AddBeroepsProduct(beroepsProduct);
        courseWeekInrichting.AddToets(schriftelijkeToets);
        _dbContext.CourseWeekInrichting.Add(courseWeekInrichting);
        _dbContext.SaveChanges();
        
        courseInrichting.MaakDefintief();
        CourseUitvoering courseUitvoering = courseInrichting.StartCourseUitvoering(new DateTimeOffset(DateTime.Now));
        _dbContext.CourseUitvoering.Add(courseUitvoering);
        _dbContext.SaveChanges();
        
        TentamenUitvoering tentamenUitvoering = courseUitvoering.Weken.First().Tentamen.First();
        _dbContext.TentamenUitvoering.Add(tentamenUitvoering);
        _dbContext.SaveChanges();
        
        
        Locatie locatie = new Locatie("Locatie naam", LocatieType.Fysiek);
        locatie.Adres = new Adres("Straatnaam", "1", "9999LA", "Arnhem");
        _dbContext.Locatie.Add(locatie);
        _dbContext.SaveChanges();
        
        Student student = new Student("student", "achternaam", "s.achternaam@example.com");
        _dbContext.Student.Add(student);
        _dbContext.SaveChanges();
        
        Opleiding opleiding = new Opleiding("ICT", "han-hbo-ict");
        OpleidingsProfiel opleidingsProfiel = new OpleidingsProfiel("Software Development", "sd");
        opleiding.AddOpleidingsProfiel(opleidingsProfiel);
        student.VolgtProfiel = opleidingsProfiel;
        _dbContext.Opleiding.Add(opleiding);
        _dbContext.SaveChanges();
        
        Klas klas = new Klas("hbo-ict-2bhj");
        klas.AddStudent(student);
        klas.DocentId = docent.Id;
        _dbContext.Klas.Add(klas);
        _dbContext.SaveChanges();
        
        _dbContext.Beoordeling.Add(new Beoordeling(tentamenUitvoering, student, docent)) ;
        _dbContext.SaveChanges();
        
    }

    public override void CreateDatabaseIfNotExists()
    {
        _logger.LogInformation("Ensuring database does exist");
        
        _dbContext.Database.EnsureCreated();
        _dbContext.Database.Migrate();
    }
}