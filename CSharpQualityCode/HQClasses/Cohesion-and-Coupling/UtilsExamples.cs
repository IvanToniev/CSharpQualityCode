using System;

namespace CohesionAndCoupling
{
    class UtilsExamples
    {
        static void Main()
        {
            Console.WriteLine(File.GetFileExtension("example"));
            Console.WriteLine(File.GetFileExtension("example.pdf"));
            Console.WriteLine(File.GetFileExtension("example.new.pdf"));

            Console.WriteLine(File.GetFileNameWithoutExtension("example"));
            Console.WriteLine(File.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(File.GetFileNameWithoutExtension("example.new.pdf"));

            Point2D point1 = new Point2D(1, -2);
            Point2D point2 = new Point2D(3,4);

            Point3D firstPoint = new Point3D(5, 2 ,-1);
            Point3D secondPoint = new Point3D(3, -6, -4);

            Console.WriteLine("Distance in the 2D space = {0:f2}",
            Figure.CalcDistance2D(point1, point2));
            Console.WriteLine("Distance in the 3D space = {0:f2}",
            Figure.CalcDistance3D(firstPoint,secondPoint));

            Figure figure = new Figure(3,4,5);

            Console.WriteLine("Volume = {0:f2}", figure.CalcVolume());
            Console.WriteLine("Diagonal XYZ = {0:f2}", figure.CalcDiagonalXYZ());
            Console.WriteLine("Diagonal XY = {0:f2}", figure.CalcDiagonalXY());
            Console.WriteLine("Diagonal XZ = {0:f2}", figure.CalcDiagonalXZ());
            Console.WriteLine("Diagonal YZ = {0:f2}", figure.CalcDiagonalYZ());
        }
    }
}
