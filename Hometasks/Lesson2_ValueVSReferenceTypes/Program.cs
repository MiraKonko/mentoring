using System;

namespace Lesson2_ValueVSReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            ValueTypeMethod();
            ReferenceTypeMethod();
            Console.WriteLine("Test Message");
            Console.ReadLine();
        }

        static void ValueTypeMethod()
        {
            string color1 = "red";
            string color2 = color1;
            color1 = "green";
            Console.WriteLine(color2);
        }

        static void ReferenceTypeMethod()
        {

            var color1 = new A { Color = ConsoleColor.Blue };
            var color2 = new A { Color = ConsoleColor.Red };
            color2 = color1;
            color1.Color = ConsoleColor.Yellow;
            Console.BackgroundColor = color2.Color;

        }


    }

    class A
    {
        public ConsoleColor Color
        {
            get;
            set;
        }
    }
}

