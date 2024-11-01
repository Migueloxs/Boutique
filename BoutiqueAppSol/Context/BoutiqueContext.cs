using BoutiqueWebAppSol.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace BoutiqueWebAppSol.Data.Context
{
    public class BoutiqueContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("");
        }

        public DbSet<Web> Webs { get; set; }
    }
}
