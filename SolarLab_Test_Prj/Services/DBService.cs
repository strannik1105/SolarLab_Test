using Microsoft.EntityFrameworkCore;
using SolarLab_Test_Prj.Models;

namespace SolarLab_Test_Prj.Services
{
    public class DBService: DbContext
    {
        public DBService(DbContextOptions<DBService> options) : base(options) { }

        public DbSet<Person> Person { get; set; }
    }
}
