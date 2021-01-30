using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work12Jan
{
    class Shapes
    {
        protected int Radius = 10;
        protected internal double AreaShape = 254.58;
        private protected string NameShape = "Siri";
    }
    class Circle:Shapes
    {
        static void Main()
        {
            Circle c1 = new Circle();
            Console.WriteLine(c1.AreaShape);
           Console.WriteLine($" Possible:{c1.Radius} and {c1.NameShape}");
        }
    }
}
