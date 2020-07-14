using AspNetCoreTest.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreTest.DataAccess
{
    public class PersonDbContext: DbContext // = Database
    {
        public DbSet<Person> People { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionbuilder) 
        {
            optionbuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Initial Catalog=PersonTestDb;Integrated Security=True;");
        }
    }
}
