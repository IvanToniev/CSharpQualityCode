using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CohesionAndCoupling
{
    public class Figure
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double Depth { get; set; }

        public Figure(double width, double height, double depth) 
        {
            Width = width;
            Height = height;
            Depth = depth;
        }

        public double CalcVolume()
        {
            double volume = Width * Height * Depth;
            return volume;
        }

        public static double CalcDistance2D(Point2D point1, Point2D point2) 
        {
            double distance = Math.Sqrt((point2.XCoord - point1.XCoord) * (point2.XCoord - point1.XCoord) + (point2.YCoord - point1.YCoord) * (point2.YCoord - point1.YCoord));
            return distance;
        }

        public static double CalcDistance3D(Point3D point1, Point3D point2)
        {
            double distance = Math.Sqrt((point2.XCoord - point1.XCoord) * (point2.XCoord - point1.XCoord) + (point2.YCoord - point1.YCoord) * (point2.YCoord - point1.YCoord) + (point2.ZCoord - point1.ZCoord) * (point2.ZCoord - point1.ZCoord));
            return distance;
        }

        public double CalcDiagonalXYZ()
        {
            double distance = CalcDistance3D(new Point3D(0, 0, 0), new Point3D(Width,Height,Depth));
            return distance;
        }

        public double CalcDiagonalXY()
        {
            double distance = CalcDistance2D(new Point2D(0, 0), new Point2D(Width,Height));
            return distance;
        }

        public double CalcDiagonalXZ()
        {
            double distance = CalcDistance2D(new Point2D(0, 0), new Point2D(Width, Depth));
            return distance;
        }

        public double CalcDiagonalYZ()
        {
            double distance = CalcDistance2D(new Point2D(0, 0), new Point2D(Height, Depth));
            return distance;
        }
    }
}
