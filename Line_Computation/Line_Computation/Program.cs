using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line_Computation
{
    public class Program
    {
        static void Main(string[] args)
        {
            //X1 coordinate:-
            Console.WriteLine("Enter X1 Coordinate");
            double x1=Convert.ToDouble(Console.ReadLine());

            //Y1 coordinate
            Console.WriteLine("Enter Y1 Coordinate");
            double y1=Convert.ToDouble(Console.ReadLine());

            //X2 coordinate
            Console.WriteLine("Enter X2 Coordinate");
            double x2=Convert.ToDouble(Console.ReadLine());

            //Y2 coordinate
            Console.WriteLine("Enter Y2 Coordinate");
            double y2=Convert.ToDouble(Console.ReadLine());

            double Length = ((Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)))));

            Console.WriteLine("Length of Line:" + Length);
            Console.ReadLine();

        }
    }
}
