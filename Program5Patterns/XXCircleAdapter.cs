using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program5Patterns
{
    public class XXCircleAdapter :Shape
    {
        public XXCircleAdapter(XXCircle toAdapt)
        {
            Adaptee = toAdapt;
        }

        private XXCircle Adaptee;

        public override void display()
        {
            Adaptee.displayIt();
        }

        public override void undisplay()
        {
            Adaptee.undisplayIt();
        }

        public override void setColor()
        {
            Adaptee.setItsColor();
        }


        public override void fill()
        {
            Adaptee.fillIt();
        }

        public override void setLocation()
        {
            Adaptee.setLocation();
        }
        public override void getLocation()
        {
            Adaptee.getLocation();
        }
    }
}