using databaseImplement.Models;
using Microsoft.EntityFrameworkCore;

namespace databaseImplement
{
    public class Database : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-2VLTMI2\SQLEXPRESS;Initial Catalog=ExamDatabase;Integrated Security=True;MultipleActiveResultSets=True;");
            }
            base.OnConfiguring(optionsBuilder);
        }

        public virtual DbSet<SystemUnit> SystemUnits { get; set; }
        public virtual DbSet<Component> Components { get; set; }
    }
}
