using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex18
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Mark");
            int Mark = Convert.ToInt32(Console.ReadLine());
            if (Mark>=80 && Mark <=100)
            {
                Console.WriteLine("Your Grade is \t  A");
            
            }
            else if (Mark >= 60 && Mark <= 79)
            {
                Console.WriteLine("Your Grade is \t  B");
            }
            else if (Mark >= 40 && Mark <= 59)
            {
                Console.WriteLine("Your Grade is \t C");
            }
            else if (Mark >= 0 && Mark <= 40)
            {
                Console.WriteLine("Your Grade is \t  F");

            }
            else  if (Mark<0)
            {
                Console.WriteLine("Your Grade is \t  Error");
            }
            else if (Mark > 100)
            {
                Console.WriteLine("Your Grade is \t Error");
            }




        }
    }
}