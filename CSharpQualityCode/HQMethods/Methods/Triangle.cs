using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class Triangle
    {
        private double aSide;
        private double bSide;
        private double cSide;

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            this.ASide = firstSide;
            this.BSide = secondSide;
            this.CSide = thirdSide;
        }
        public double CSide
        {
            get
            {
                return this.cSide;
            }
            set
            {
                this.cSide = value;
            }
        }

        public double BSide
        {
            get
            {
                return this.bSide;
            }
            set
            {
                this.bSide = value;
            }
        }

        public double ASide
        {
            get
            {
                return this.aSide;
            }
            set
            {
                this.aSide = value;
            }
        }
    }
}
