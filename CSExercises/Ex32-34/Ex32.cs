using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex32
    {
        public static void Main(string[] args)
    {
        int[] sales = new int[12];
        int amount = 0;
        for (int i=0; i<12; i++)
    {
        Console.Write("Enter amount of the Month{0}:\t",i);
        sales[i] = Convert.ToInt32(Console.ReadLine());
        amount = amount + sales[i];
    }
    // Finding Maximum Sales 
        int max = sales.Max(); 
        int m = sales.ToList().IndexOf(max);
        Console.WriteLine("Maximum Sales:\t{0}", m);
    // Finiding Minimum Sales

        int min = sales.Min();
        int n = sales.ToList().IndexOf(min);
        Console.WriteLine("Minimum Sales:\t{0}", n);

       // Finding the Average
        int avg = amount / 12;
        Console.WriteLine("Average sales:" + avg);



        }



        }
    }
