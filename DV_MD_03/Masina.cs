using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DV_MD_03
{
    public class Masina
    {
        public string Brand { get; set; }
        public string NumberPlate { get; set; }
        public int Speed { get; set; }

        public void Drive()
        {
            Speed = 1;
            Console.WriteLine("Start driving");
        }
        public int IncreaseSpeed()
        {
            Speed +=1;
            Console.WriteLine("Drive faster" + Speed);
            return Speed;
        }

        public int StopDriving ()
        {
            Speed = 0;
            Console.WriteLine("Stops driving");
            return Speed;
        }

        public int ReduceSpeed ()
        {
            Speed -=1;
            Console.WriteLine("Drive slower"+ Speed);
            return Speed;
        }

        public void BeepBeep ()
        {
            Console.WriteLine("Beep beep");
            
        }
    }
}
