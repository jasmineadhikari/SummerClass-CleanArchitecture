using Microsoft.EntityFrameworkCore;
using TestProject.Application.Common.Interface;
using TestProject.Domain.Entities;

namespace TestProject.Infrastructure.Persistance;

public class ApplicationDbContext : DbContext, IApplicationDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : base(options)
    {
        
    }
    public DbSet<Employee> Employee { get; set; }
}