using SolarLab_Test_Prj.Models;
using SolarLab_Test_Prj.Services;

namespace SolarLab_Test_Prj.Repository
{
    public class PersonRepository: IPerson
    {
        DBService DB;

        public PersonRepository(DBService DB)
        {
            this.DB = DB;
        }

        public IEnumerable<Person> Persons => DB.Person;

        public IEnumerable<Person> SoonBirthday => DB.Person.Where(p => (p.BirthdayDate - DateTime.Now).CompareTo(TimeSpan.FromDays(5)) <= 0);

        public IEnumerable<Person> TodayBirthday => DB.Person.Where(p => (p.BirthdayDate.Date == DateTime.Today));

        public Person GetPerson(int id) => DB.Person.FirstOrDefault(p => p.Id == id);
    }
}
