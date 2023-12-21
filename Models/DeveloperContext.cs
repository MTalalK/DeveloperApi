using Microsoft.EntityFrameworkCore;

namespace DeveloperApi.Models;

public class DeveloperContext : DbContext
{
    public DeveloperContext(DbContextOptions<DeveloperContext> options)
        : base(options)
    {
    }

    public DbSet<Developer> Developers { get; set; } = null!;
}