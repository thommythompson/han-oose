using HAN.ICDETool.Core.Entities;
using HAN.ICDETool.Infrastructure.Data.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace HAN.ICDETool.Infrastructure.Data;

public class ICDEContext : DbContext
{
    private readonly IConfiguration _configuration;
    private readonly string _connectionString;
    
    public DbSet<LesInrichting> LesInrichting { get; set; }
    public DbSet<LesMateriaal> LesMateriaal { get; set; }
    public DbSet<CourseWeekInrichting> CourseWeekInrichting { get; set; }
    public DbSet<TentamenUitvoering> TentamenUitvoering { get; set; }
    public DbSet<Student> Student { get; set; }
    public DbSet<Rubric> Rubric { get; set; }
    public DbSet<OpleidingsProfiel> OpleidingsProfiel { get; set; }
    public DbSet<Opleiding> Opleiding { get; set; }
    public DbSet<Locatie> Locatie { get; set; }
    public DbSet<LesUitvoering> LesUitvoering { get; set; }
    public DbSet<Leeruitkomst> Leeruitkomst { get; set; }
    public DbSet<Leerdoel> Leerdoel { get; set; }
    public DbSet<Klas> Klas { get; set; }
    public DbSet<EenheidVanLeeruitkomsten> EenheidVanLeeruitkomsten { get; set; }
    public DbSet<Docent> Docent { get; set; }
    public DbSet<CourseWeekUitvoering> CourseWeekUitvoering { get; set; }
    public DbSet<CourseUitvoering> CourseUitvoering { get; set; }
    public DbSet<CourseInrichting> CourseInrichting { get; set; }
    public DbSet<BeroepsProduct> BeroepsProduct { get; set; }
    public DbSet<SchriftelijkeToets> SchriftelijkeToets { get; set; }
    public DbSet<BeoordelingsCriteria> BeoordelingsCriteria { get; set; }
    public DbSet<Beoordeling> Beoordeling { get; set; }
    public DbSet<Adres> Adres { get; set; }

    // No parameter constructor for EF core power tools
    public ICDEContext()
    {
        _connectionString = "Server=127.0.0.1; Database=IcdeTool; User Id=sa; Password=P@ssw0rd; MultipleActiveResultSets=true; TrustServerCertificate=true";
    }

    public ICDEContext(IConfiguration configuration)
    {
        _configuration = configuration;
        _connectionString = _configuration.GetConnectionString("Default");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(_configuration.GetConnectionString("Default"));
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(CourseWeekUitvoeringEntityTypeConfiguration).Assembly);
        
        

    }
}