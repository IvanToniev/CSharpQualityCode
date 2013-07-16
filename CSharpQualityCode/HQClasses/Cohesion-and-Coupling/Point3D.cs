using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CohesionAndCoupling
{
    public class Point3D
    {
        public double XCoord { get; set; }
        public double YCoord { get; set; }
        public double ZCoord { get; set; }

        public Point3D(double xCoord, double yCoord, double zCoord)
        {
            this.XCoord = xCoord;
            this.YCoord = yCoord;
            this.ZCoord = zCoord;
        }
    }
}
