using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CohesionAndCoupling
{
    public class Point2D:Point
    {
        public double XCoord { get; set; }
        public double YCoord { get; set; }

        public Point2D(double xCoord, double yCoord)
        {
            this.XCoord = xCoord;
            this.YCoord = yCoord;
        }
    }
}
