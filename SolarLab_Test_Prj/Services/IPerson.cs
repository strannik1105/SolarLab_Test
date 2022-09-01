using SolarLab_Test_Prj.Models;

namespace SolarLab_Test_Prj.Services
{
    public interface IPerson
    {
        public IEnumerator<Person> Persons { get; set; }
        
        public Person GetPerson(int id);

        public IEnumerator<Person> TodayBirthday { get; }

        public IEnumerator<Person> SoonBirthday { get; }


    }
}
