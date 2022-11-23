using System.Linq.Expressions;
using HAN.ICDETool.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace HAN.ICDETool.Infrastructure.Data;

public class ICDEContext : DbContext
{
    private readonly IConfiguration _configuration;

    public DbSet<LesInrichting> LesInrichting { get; set; }
    public DbSet<LesMateriaal> LesMateriaal { get; set; }

    public ICDEContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(_configuration.GetConnectionString("Default"));
    }
}