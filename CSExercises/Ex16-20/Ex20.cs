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

            Console.WriteLine("Please enter the TV Product");
            int tv_qty = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the DVD Produc");
            int dvd_qty = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the MP3 Amount");
            int Mp3_qty = Convert.ToInt32(Console.ReadLine());
            double TV_Price = tv_qty * 900;
            double Dvd_Price = dvd_qty * 500;
            double Mp3_Price = Mp3_qty * 700;
            double Total_Price = TV_Price + Dvd_Price + Mp3_Price;
            if (Total_Price > 5000 && Total_Price < 10000)
            {
                TV_Price = TV_Price * 0.9;
                Dvd_Price = Dvd_Price * 0.9;
            }
            else if (Total_Price > 10000)
            {
                TV_Price = TV_Price * 0.85;
                Dvd_Price = Dvd_Price * 0.85;
            }
            Total_Price = TV_Price + Dvd_Price + Mp3_Price;
            Console.WriteLine("Total price of this order is {0:c}", Total_Price);


        }
    }
}

