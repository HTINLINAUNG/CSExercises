/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex38
    {
        public static void Main(string[] args)
        {
            int temp = 0;

            string[] arrayname = new string[] { "John","Venkat","Mary","Victor","Betty"};
            int[] arrayMarks = new int[] { 63,29,75,82,55};
            for ( int i=0;i<arrayMarks.Length;i++)
             { for (int j=arrayMarks.Length;j>=1;j--)
             {
                 if (arrayMarks[j] > arrayMarks[i])
                 {
                     temp = arrayMarks[j];
                     arrayMarks[j] = arrayMarks[i];
                     arrayMarks[i] = temp;
                 
                 }


               }
             Console.WriteLine("The descending order of the Marks are \t" + arrayMarks[i]);
             for (int i = 0; i < arrayMarks.Length; i++)
             {
                 Console.WriteLine(arrayMarks[i]);
             }
                 }
                  }
                }
}
*/