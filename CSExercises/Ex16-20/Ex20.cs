using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex20
    {
        public static void Main(string[] args)
        {
            int TV, DVD, MP3, Total;
            int dismp3;
            Console.WriteLine("Enter the Quantitiy of the TV ");
            TV = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Quantity of the DVD");
            DVD = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Quantity of the MP3");
            MP3 = Convert.ToInt32(Console.ReadLine());
            dismp3 = (700 * MP3);
            Total = ((TV * 900) + (DVD * 500));
            if (Total > 5000)
            {
                Console.WriteLine("The Total Price of the Order is  \t" + ((Total * 0.90) + dismp3));
            }
            else if (Total > 10000)
            {
                Console.WriteLine("The Total Price of the Order is \t" +( (Total * 0.85) + dismp3));
            }


        }
    }
}

