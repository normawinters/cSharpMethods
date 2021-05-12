using System;
using System.Linq;

namespace cSharpMethods
{
    class Program
    {

        static void MyMethod()
        {
            Console.WriteLine("Called from Main.");
        }

        static void MyBoxCubicCounter(int NbrBoxes = 0, string BoxType = "large")
        {
            string SmallboxTypeString = "small";
            string MediumboxTypeString = "medium";
            string LargeboxTypeString = "large";
            int cubicTot = 0;

            if (BoxType == SmallboxTypeString)
            {
                cubicTot = 1 * NbrBoxes;
            }

            if (BoxType == MediumboxTypeString)
            {
                cubicTot = 2 * NbrBoxes;
            }
            if (BoxType == LargeboxTypeString)
            {
                cubicTot = 3 * NbrBoxes;
            }

            Console.WriteLine("Cubic Total for "+NbrBoxes+" "+BoxType+ " boxes: " +cubicTot);
            Console.WriteLine("Called from overloading function with double:  " );

        }
        

        static void MyBoxCubicCounter(double NbrBoxes = 0, string BoxType = "large")
        {
            string SmallboxTypeString = "small";
            string MediumboxTypeString = "medium";
            string LargeboxTypeString = "large";
            double cubicTot = 0;


            if (BoxType == SmallboxTypeString)
            {
                cubicTot = 1 * NbrBoxes;
            }

            if (BoxType == MediumboxTypeString)
            {
                cubicTot = 2 * NbrBoxes;
            }
            if (BoxType == LargeboxTypeString)
            {
                cubicTot = 3 * NbrBoxes;
            }

            Console.WriteLine("Cubic Total for " + NbrBoxes + " " + BoxType + " boxes: " + cubicTot);
        }





        static void Main(string[] args)
        {
            Console.WriteLine("cSharp Methods and arrays");

            int[] myNumbers = { 10, 0, 5, 20 };

            Console.WriteLine("10  0 5 20");
            ;
            Console.WriteLine("Max " + myNumbers.Max());
            Console.WriteLine("Min " + myNumbers.Min());
            Console.WriteLine("Sum " + myNumbers.Sum());

            string[] myHome = { "aparment", "loft", "house", "cabin" };

            Console.WriteLine("aparment loft house cabin");

            Console.WriteLine("Max  " + myHome.Max());
            Console.WriteLine("Min  " + myHome.Min());
            //  Console.WriteLine(myHome.Sum());


            Console.WriteLine(" ");


            Console.WriteLine("c sharp methods  ");

            Console.WriteLine("---------------  ");


            Console.WriteLine("Methods are similiar to functions , pass parameters, you need to call a method to run it.    ");
            Console.WriteLine("Examples of predifined methods are Sum, Max, Min ");
            Console.WriteLine("static belongs to Program class, void does not return value.");
            Console.WriteLine("---------------  ");
            MyMethod();

            int boxnbr = default(int);
            int boxnbr2 = default;

            MyBoxCubicCounter(5, "small");
            MyBoxCubicCounter(boxnbr, null);
            MyBoxCubicCounter(boxnbr2, null);
            MyBoxCubicCounter(5, "medium");
            MyBoxCubicCounter(5, "large");
            MyBoxCubicCounter(5.1, "large");


        }
    }
}