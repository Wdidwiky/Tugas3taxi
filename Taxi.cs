using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    public class Taxi
    {
        public string DriverName { get; set; }
        public int NumPassenger {get; set; }
        public bool Onduty { get; set; }

        public void TaxiInfo()
        {
            string duty;
            if(Onduty)
            {
                duty = "yes";
            }else
            {
                duty = "no";
            }
            Console.WriteLine("Driver Name : {0}", DriverName);
            Console.WriteLine("On Duty : {0}", Onduty);
            Console.WriteLine("Number Of Passenger : {0}", NumPassenger);
            Console.WriteLine();
        }
        public void PickUpPassenger()
        {
            Console.WriteLine("{0} Sedang menjemput penumpang", DriverName);
        }
        public void DropOffPassenger()
        {
            Console.WriteLine("{0} Selesai mengantar penumpang", DriverName);
        }
    }
