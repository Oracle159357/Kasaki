using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Text.RegularExpressions;
using Kasaki.Entities;

namespace Kasaki
{
    public class RozkladContext : DbContext
    {
        public RozkladContext(): base("name=RozkladContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }

        static RozkladContext()
        {
            Database.SetInitializer(new DataModelInitializer());
        }
        public DbSet<User1> Users { get; set; }
        public DbSet<Departament1> Departaments { get; set; }
        public DbSet<Group1> Groups { get; set; }
        public DbSet<Lecture1> Lectures { get; set; }
        public DbSet<Room1> Rooms { get; set; }
        public DbSet<Subject1> Subjects { get; set; }
        public DbSet<Teacher1> Teachers { get; set; }
    }
}