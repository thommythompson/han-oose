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
    
    public async Task Seed()
    {
        _logger.LogInformation("Start seeding database");
        
        CourseWeekInrichting courseWeekInrichting = new CourseWeekInrichting();
        LesInrichting lesInrichting = new LesInrichting("titel", courseWeekInrichting);
        
        lesInrichting.VoegMateriaalToe("titel", "inhoud");

        // TODO: hoe run je async?
        await _dbContext.LesInrichting.AddAsync(lesInrichting);
 
        await _dbContext.SaveChangesAsync();
    }

    public void Create()
    {
        _logger.LogInformation("Creating database");
        
        _dbContext.Database.EnsureCreated();
        _dbContext.Database.Migrate();
    }
}