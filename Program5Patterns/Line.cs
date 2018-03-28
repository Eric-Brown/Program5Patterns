using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program5Patterns
{
    public class Line : Shape
    {
        public override void display()
        {
            Console.WriteLine("Line's display");
        }

        public override void fill()
        {
            Console.WriteLine("Line's fill");
        }

        public override void undisplay()
        {
            Console.WriteLine("Line's undisplay");
        }
    }
}