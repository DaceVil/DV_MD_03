
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

            ///Ka pasniedzējs domāja :
            ///int birthYear=1964;
            ///DatiTime now = DateTime.Now;
            ///DateTime utcNow = DateTime.UtcNow; UTC time zone arī var lietot
            //int yearsOld = now.Year - birthYear;
            -----------
            //string format = "dd.mm.yyyy";
            //Console.Write("Enter date of Birth in format DD.MM.YYYY: ");
            //DateTime birthDate = DateTime.ParseExact(Console.ReadLine(), format, CultureInfo.InvariantCulture);


        }

        public string Gender { get; set; }

        public string Hobby { get; set; }
        public void SayHi()
        {
         
            Console.WriteLine($"Hello my name is: {Name} {LastName} and I am {BirthYear}");
        }
    }
    ---------------------------------------

    public class Human
    {
        public Human(string name)
        {
            Name = name;
        }

        /// <summary>
        /// 1.Ir set var uzstādīt visi visur
        /// 2.Private set var uzstādīt tikai klases iekšienē jebkurā brīdī
        /// 3.Nav set vispār var uzstādīt tikai konstruktorā
        /// </summary>
        public string Name { get; set; }

        public void SS()
        {
            Name = "sss"
        }
    }
}
