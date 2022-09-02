using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace SolarLab_Test_Prj.Models
{
    public class Person
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Image { get; set; }

        public DateTime BirthdayDate { get; set; }

        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile ImageFile { get; set; }
    }
}
