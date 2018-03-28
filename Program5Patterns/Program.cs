using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Program5Patterns
{
    /// <summary>
    /// Class that is a test driver for the shapes hierarchy
    /// </summary>
    class Program
    {
        private static List<Shape> shapes = new List<Shape>();
        private enum KNOWNSHAPETYPES { LINE, RECTANGLE, POINT, XXCIRCLE}
        private const uint NUM_SHAPES_TO_CREATE = 40;
        /// <summary>
        /// Entry point for test driver.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            /*
             * Write skeleton code that just uses print statements for all the methods, 
             * and write a test driver that creates a sequence of Shapes and displays
             * all of the shapes it contains, verifying that your Circle class nicely 
             * coexists with the other types of Shape.
             */
            PopulateShapes();
            DisplayShapes();
            SetShapes();
            UndisplayShapes();
            Console.ReadKey();
        }

        private static void UndisplayShapes()
        {
            foreach (var shape in shapes)
                shape.undisplay();
        }

        private static void SetShapes()
        {
            foreach (var shape in shapes)
                shape.setLocation();
        }

        private static void DisplayShapes()
        {
            foreach (var shape in shapes)
                shape.display();
        }

        private static void PopulateShapes()
        {
            Random random = new Random();
            var types = Enum.GetValues(typeof(KNOWNSHAPETYPES));
            for (int i = 0; i < NUM_SHAPES_TO_CREATE; i++)
            {
                KNOWNSHAPETYPES choosen = (KNOWNSHAPETYPES)types.GetValue(random.Next(types.Length));
                switch(choosen)
                {
                    case KNOWNSHAPETYPES.LINE:
                        shapes.Add(new Line());
                        break;
                    case KNOWNSHAPETYPES.POINT:
                        shapes.Add(new Point());
                        break;
                    case KNOWNSHAPETYPES.RECTANGLE:
                        shapes.Add(new Rectangle());
                        break;
                    case KNOWNSHAPETYPES.XXCIRCLE:
                        shapes.Add(new XXCircleAdapter(new XXCircle()));
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
