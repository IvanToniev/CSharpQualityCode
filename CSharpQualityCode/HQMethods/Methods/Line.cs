using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class Line
    {
        private Point point1;
        private Point point2;

        public Line(Point point1, Point point2)
        {
            this.Point1 = point1;
            this.Point2 = point2;
        }

        public Point Point2
        {
            get
            {
                return this.point2;
            }
            set
            {
                this.point2 = value;
            }
        }

        public Point Point1
        {
            get
            {
                return this.point1;
            }
            set
            {
                this.point1 = value;
            }
        }
    }
}
