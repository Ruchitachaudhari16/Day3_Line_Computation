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
            //Find the length of line using x1,x2,y1,y2 coordinates.
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

            // UC2:- Check equality of 2 lines (x1,y1)(x2,y2),(x3,y3),(x4,y4)
            //X3 coordinate 
            Console.WriteLine("Enter the X3 Coordinate");
            double x3=Convert.ToDouble(Console.ReadLine());

            //Y3 coordinate
            Console.WriteLine("Enter the Y3 Coordinate");
            double y3=Convert.ToDouble(Console.ReadLine());

            //X4 coordinate
            Console.WriteLine("Enter the X4 Coordinate");
            double x4=Convert.ToDouble(Console.ReadLine());

            //Y4 coordinate
            Console.WriteLine("Enter the Y4 Coordinate");
            double y4= Convert.ToDouble(Console.ReadLine());

            //Calculate length of line2
            double Length1 = ((Math.Sqrt(((x4 - x3) * (x4 - x3)) + ((y4 - y3) * (y4 - y3)))));

            Console.WriteLine("Length of Line:" + Length1);

            //Check the equality of 2 lines.
             bool equalLength = Length.Equals(Length1);
            if (equalLength == true)
            {
                Console.WriteLine("Length of line1 and Line2 are equal");
            }
            //length of line1 is greater.
            else if(Length >Length1)
            { 
                Console.WriteLine("Length of line1 is greater");
            }
            //length of line2 is greater.
            else  
            {
                Console.WriteLine("Length of Line2 is greater");
            }



            Console.ReadLine();

        }
    }
}
