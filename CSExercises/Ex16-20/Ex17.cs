using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex17
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Name");
            string Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Your Sex");
            String Sex = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Your Age");
            double age = Convert.ToDouble(Console.ReadLine());
            if (age >= 40 && Sex == "M")
            {
                Console.WriteLine("Good Morning \t  Uncle" + Name);

            }
            else if (age<40 && Sex == "M")

            {
                Console.WriteLine("Good Morning \t Mr" + Name);
            }
            else if (age >= 40 && Sex == "F")
            {
                Console.WriteLine("Good Morning \t Aunty" + Name);
            }
            else if (age < 40 && Sex == "F")
            {
                Console.WriteLine("Good Morning \t Ms" + Name);
            }

        }
    }
}