using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program5Patterns
{
    public abstract class Shape
    {
        public virtual void setLocation()
        {
            Console.WriteLine("Shape's setLocation.");
        }

        public virtual void getLocation()
        {
            Console.WriteLine("Shape's getLocation");
        }

        public abstract void display();

        public abstract void fill();

        public virtual void setColor()
        {
            Console.WriteLine("Shape's setColor");
        }

        public abstract void undisplay();
    }
}