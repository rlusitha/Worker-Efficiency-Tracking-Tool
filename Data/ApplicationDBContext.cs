using Microsoft.EntityFrameworkCore;
using Personal_Project.Models.Entities;

namespace Personal_Project.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
            
        }

        public DbSet<Item> Items { get; set; }
    }
}
