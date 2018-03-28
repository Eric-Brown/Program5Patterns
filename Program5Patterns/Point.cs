using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program5Patterns
{
    public class Point : Shape
    {
        public override void display()
        {
            Console.WriteLine("Point's display");
        }

        public override void fill()
        {
            Console.WriteLine("Point's fill");
        }

        public override void undisplay()
        {
            Console.WriteLine("Point's undisplay");
        }
    }
}