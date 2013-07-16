using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class Point
    {
        private double xCoord;
        private double yCoord;

        public Point()
        {
            this.XCoord = 0;
            this.YCoord = 0;
        }

        public Point(double xCoord, double yCoord) {
            this.XCoord = xCoord;
            this.YCoord = yCoord;
        }

        public double YCoord
        {
            get
            {
                return this.yCoord;
            }
            set
            {
                this.yCoord = value;
            }
        }

        public double XCoord
        {
            get
            {
                return this.xCoord;
            }
            set
            {
                this.xCoord = value;
            }
        }
    }
}
