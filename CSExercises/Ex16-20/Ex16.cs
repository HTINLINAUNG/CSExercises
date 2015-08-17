using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex16
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("Enter Your Name");
            string name =Convert.ToString( Console.ReadLine());
            Console.WriteLine("Enter Your Sex");
            string sex = Convert.ToString(Console.ReadLine());
           
            {
                if (sex == "M")
                {
                    Console.WriteLine("Good Morning  \t Mr"+name);
                
                }

                else if (sex == "F")
                {
                    Console.WriteLine("Good Morning \t Ms"+name);
                }
            
            }
          
        }
    }
}