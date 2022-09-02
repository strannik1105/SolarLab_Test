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

        public IEnumerable<Person> SoonBirthday       {
            get
            {
                List<Person> to_return = new List<Person>();
                var persons = Persons;
                foreach (var person in persons)
                {
                    DateTime bday = new DateTime(10, person.BirthdayDate.Month, person.BirthdayDate.Day);
                    if (bday - (new DateTime(10, DateTime.Now.Month, DateTime.Now.Day)) >= (new TimeSpan(0, 0, 0, 0)))
                    {
                        if (bday - (new DateTime(10, DateTime.Now.Month, DateTime.Now.Day)) <= (new TimeSpan(7, 0, 0, 0)))
                        {
                            to_return.Add(person);
                        }
                    }
                }
                return to_return;
            }
        }
        public IEnumerable<Person> TodayBirthday => DB.Person.Where(p => (p.BirthdayDate.Date == DateTime.Today));

        public Person GetPerson(int id) => DB.Person.FirstOrDefault(p => p.Id == id);
    }
}
