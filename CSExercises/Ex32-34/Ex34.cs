using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading;

namespace CSExercises
{
    public class Ex34
    {
        public static void Main(string[] args)
        {
            int i, j = 0;
            int[,] Marks = new int[12, 4] { { 56, 84, 68, 29 }, { 94, 73, 31, 89 }, { 41, 63, 36, 90 }, { 99, 9, 18, 17 }, { 62, 3, 65, 75 }, { 40, 96, 53, 23 }, { 81, 15, 27, 30 }, { 21, 70, 100, 22 }, { 88, 50, 13, 12 }, { 48, 54, 52, 78 }, { 64, 71, 67, 25 }, { 16, 93, 46, 72 } };
            double classavg, final_mark;

            for (i = 0; i < 12; i++)
            {
                final_mark = 0;
                for (j = 0; j < 4; j++)
                {
                    final_mark = final_mark + Marks[i, j];
                }
                Console.WriteLine("Total Marks Obtained each Student \t" + final_mark);
            }



            for (i = 0; i < 4; i++)
            {
                classavg = 0;
                for (j = 0; j < 12; j++)
                { classavg = classavg + Marks[j, i]; }

                Console.WriteLine("Class Average is" + classavg / 12);
            
            }
        


        }
    }
}