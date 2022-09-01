using SolarLab_Test_Prj.Models;

namespace SolarLab_Test_Prj.Services
{
    public interface IPerson
    {
        public IEnumerable<Person> Persons { get; }
        
        public Person GetPerson(int id);

        public IEnumerable<Person> TodayBirthday { get; }

        public IEnumerable<Person> SoonBirthday { get; }


    }
}
