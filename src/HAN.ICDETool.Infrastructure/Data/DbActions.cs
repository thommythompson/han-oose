using HAN.ICDETool.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace HAN.ICDETool.Infrastructure.Data;

public class DbActions : IDbActions
{
    private readonly ICDEContext _dbContext;
    private readonly ILogger<DbActions> _logger;

    public DbActions(ICDEContext dbContext, ILogger<DbActions> logger)
    {
        _dbContext = dbContext;
        _logger = logger;
    }
    
    public void Seed()
    {
        _logger.LogInformation("Start seeding database");
        
        Locatie locatie = new Locatie("Locatie naam", LocatieType.Fysiek);
        locatie.Adres = new Adres("Straatnaam", "1", "9999LA", "Arnhem");
        _dbContext.Locatie.Add(locatie);

        Docent docent = new Docent("docent", "achternaam", "d.achternaam@example.com");
        _dbContext.Docent.Add(docent);
        
        Student student = new Student("student", "achternaam", "s.achternaam@example.com");
        _dbContext.Student.Add(student);

        CourseInrichting courseInrichting = new CourseInrichting("titel", "omschrijving", docent);
        EenheidVanLeeruitkomsten eenheidVanLeeruitkomsten = new EenheidVanLeeruitkomsten("titel", "omschrijving");
        Leeruitkomst leeruitkomst = new Leeruitkomst("titel","omschrijving");
        Leerdoel leerdoel = new Leerdoel("titel", "omschrivjing");
        leeruitkomst.KoppelLeerdoel(leerdoel);
        eenheidVanLeeruitkomsten.AddLeeruitkomst(leeruitkomst);
        courseInrichting.AddEenheidVanLeeruitkomsten(eenheidVanLeeruitkomsten);
        courseInrichting.AddToets(new SchriftelijkeToets("titel", leerdoel));
        
        LesInrichting lesInrichting = new LesInrichting("Titel", leerdoel);
        lesInrichting.AddLesMateriaal(new LesMateriaal());
        _dbContext.LesInrichting.Add(lesInrichting);

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
        
        _dbContext.Add(courseInrichting);
        
        _dbContext.SaveChanges();
    }

    public void Create()
    {
        _logger.LogInformation("Creating database");
        
        _dbContext.Database.EnsureCreated();
        _dbContext.Database.Migrate();
    }

    public void CreateAndSeed()
    {
        Create();
        
        Seed();
    }
}