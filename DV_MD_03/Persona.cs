
namespace DV_MD_03
{
    public class Persona
    {
   
        public string Name { get; set; }

        public string LastName { get; set; }
        public DateTime BirthYear { get; set; }

        public int Age()

        {
            DateTime now = DateTime.Today;
            int age = now.Year - BirthYear.Year;
            return age;

            //return DateTime.Now.Year - BirthDate.Year;

        }

        public string Gender { get; set; }

        public string Hobby { get; set; }
        public void SayHi()
        {
         
            Console.WriteLine($"Hello my name is: {Name} {LastName} and I am {BirthYear}");
        }
    }
}
