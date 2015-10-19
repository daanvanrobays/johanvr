using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using JohanVanRobays.Models.Mapping;

namespace JohanVanRobays.Models
{
    public partial class johanvanrobaysContext : DbContext
    {
        static johanvanrobaysContext()
        {
            Database.SetInitializer<johanvanrobaysContext>(null);
        }

        public johanvanrobaysContext()
            : base("Name=johanvanrobaysContext")
        {
        }

        public DbSet<JDC> JDCs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new JDCMap());
        }
    }
}
