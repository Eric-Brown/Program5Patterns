using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program5Patterns
{
    public class Rectangle : Shape
    {
        public override void display()
        {
            Console.WriteLine("Rectangle's display");
        }

        public override void fill()
        {
            Console.WriteLine("Rectangle's fill");
        }

        public override void undisplay()
        {
            Console.WriteLine("Rectangle's undisplay");
        }
    }
}