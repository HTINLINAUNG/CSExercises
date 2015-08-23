using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex45
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount to exchange currency");
            double number = Convert.ToInt32(Console.ReadLine());
            int completenumber = Convert.ToInt32(number * 100);
            int[] cent = new int[] { 100, 50, 20, 10, 5 };
            for (int i = 0; i < cent.Length; i++)
            {
                while (completenumber >= cent[i])
                {
                    completenumber = completenumber - cent[i];
                    Console.WriteLine(cent[i] + "c");

                }

            }
            Console.ReadLine();

        }
    }
}