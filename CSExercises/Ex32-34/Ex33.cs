using System;
namespace CSExercises
{
    public class Ex33
    {
        public static void Main(string[] args)
        {
            int[] A = new int[] { 86, 35, 41, 49, 89, 51, 11, 71, 50, 75, 25, 58, 40, 14, 44, 3, 63, 81, 93, 79 };
            for (int green = 0; green < A.Length - 1; green++)
                for (int red = green + 1; red < A.Length; red++)
                {
                    if (A[red] > A[green])
                    {
                       //SWAP 
                        int temp = A[red];
                        A[red] = A[green];
                        A[green] = temp;
                    
                    }

                    /*if (A[red] < A[green])
                    {
                        //SWAP
                        int temp = A[red];
                        A[red] = A[green];
                        A[green] = temp;

                    }*/

                }


            for (int i = 0; i < A.Length; i++)
            {
                Console.Write("{0}\t", A[i]);
            }
            Console.WriteLine();
        }
    }
}