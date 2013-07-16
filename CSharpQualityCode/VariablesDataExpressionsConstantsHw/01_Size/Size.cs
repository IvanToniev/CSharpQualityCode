using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Size
{
    public class Size
    {
        public double width, height;
        public Size(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public static Size GetRotatedSize(Size size, double angleOfRotation)
        {
            return new Size
                (Math.Abs(Math.Cos(angleOfRotation)) * size.width +
                 Math.Abs(Math.Sin(angleOfRotation)) * size.height,
                 Math.Abs(Math.Sin(angleOfRotation)) * size.width +
                 Math.Abs(Math.Cos(angleOfRotation)) * size.height
                 );
        }
    }
}
