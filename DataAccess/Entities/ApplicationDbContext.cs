using DataAccess.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Entities
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Item> Items { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            Item item = new Item();
            item.Id = 1;
            item.Name = "вікна";
            item.Price = 755.20;

            builder.Entity<Item>().HasData(item);
        }
    }
}
