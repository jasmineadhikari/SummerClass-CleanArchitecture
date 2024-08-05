using Microsoft.EntityFrameworkCore;
using TestProject.Domain.Entities;

namespace TestProject.Application.Common.Interface;

public interface IApplicationDbContext
{
    DbSet<Employee> Employee { get; set; }
}