using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex24
    {
        public static void Main(string[] args)
        {
            double N = GetInputFromUser("Please enter a number");
            double G = GetARandomNumberBetween1andN(N);
            bool status = false;
            do
            {
                status = CheckWhetherIsTheSquareRootofN(G, N);
                if (status == false)
                {
                    G = CalculateNewG(G, N);

                }
            } while (status == false);
            Console.WriteLine(G);

        }

        // This method is used to prompt the  user supplied string and get the string from the user and  get the input , convert the input to double and return it 
        public static double GetInputFromUser(string prompt)
        {
            Console.Write(prompt);
            double output = Convert.ToDouble(Console.ReadLine());
            return output;
        
        }
        public static double GetARandomNumberBetween1andN(double N )
        { 
        Random r = new Random();
        
        double x = r.NextDouble();
            x = x*(N-1);
            x=x+1;
            return x;
        
        }
        public static bool CheckWhetherIsTheSquareRootofN(double G, double N)
     { 
        bool result = Math.Abs((G * G) - N) < 0.0001;
         return result;
     }
        public static double CalculateNewG(double G,double N)
        {
            double newG = (G + N / G) / 2;
            return newG;

        }
    }
}
