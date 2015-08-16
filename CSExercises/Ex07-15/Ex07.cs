using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex07
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Employee's Salary");
            double salary = Convert.ToDouble (Console.ReadLine());
            double housingAllowance ,TransportAllowance;
            housingAllowance=((salary/100)*10);
            TransportAllowance = ((salary / 100) * 3);
            Console.WriteLine("The total income is"+" " +(salary+housingAllowance+TransportAllowance));
           
        }
    }
}
