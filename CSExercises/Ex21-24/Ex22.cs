using System;
namespace CSExercises
{
    public class Ex22
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please Put the Value of A");
            int A= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Put the Value of B");
            int B = Convert.ToInt32(Console.ReadLine());
            int Z = A * B;
            while (A != B)
            {
                if (A> B)
                {
                    A = A - B;
                }
                else
                {
                    B= B - A;
                }

            }

            int HCF = A;

            int LCM = Z/ HCF;

            Console.WriteLine("The HCF is {0}.", HCF);
            Console.WriteLine("The LCM is {0}.", LCM);
            Console.ReadLine();
        }
    }
}
