using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pre_democracy_classifications
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string IDNumber = "9706080861004";
            if (IDNumber.Length != 13)
            {
                Console.WriteLine("ID Number is invalid.it should have 13 characters long.");
                return;
            }
            int year = int.Parse(IDNumber.Substring(0, 2));
            int month = int.Parse(IDNumber.Substring(2, 2));
            int day = int.Parse(IDNumber.Substring(4, 2));

            DateTime DateOfBirth = new DateTime(1900 + year, month, day);
            
            char GenderCode = IDNumber[6];

            string Gender = (GenderCode >= '0' && GenderCode <= '4') ? "Female" : "Male";

            char race = IDNumber[11];
           
            if (race == '0')
            {
                Console.WriteLine("race is White");
            }
            else if (race == '1')
            {
                Console.WriteLine("race is Cape Coloured ");
            }
            else if (race == '2')
            {
                Console.WriteLine("race is Malay");
            }
            else if (race == '3')
            {
                Console.WriteLine("race is Griqua");
            }
            else if (race == '4')
            {
                Console.WriteLine("race is Chinese");
            }
            else if (race == '5')
            {
                Console.WriteLine("race is Indian");
            }
            else if (race == '6')
            {
                Console.WriteLine("race is Other Asian");
            }
            else { }

            char citizenship = IDNumber[11];
            string citizenshipStatus = (citizenship == '0') ? "SA Citizen" : "Permanent Resident";

            Console.WriteLine("Date Of Birth: " + DateOfBirth.ToShortDateString());
            Console.WriteLine("Gender:" + Gender);
            Console.WriteLine("citizenship Status:" + citizenshipStatus);
            Console.WriteLine("race:"+ race);
            Console.ReadLine();

            
        }
        


    }
}
