using System;

namespace Methods
{
    class Methods
    {
        static double CalcTriangleArea(Triangle triangle)
        {
            if (triangle.ASide <= 0 || triangle.BSide <= 0 || triangle.CSide <= 0)
            {
                throw new ArgumentException("All sides should be positive!");
            }
            double halfParameter = (triangle.ASide + triangle.BSide + triangle.CSide) / 2;
            double fullArea = Math.Sqrt(halfParameter * (halfParameter - triangle.ASide) * (halfParameter - triangle.BSide) * (halfParameter - triangle.CSide));
            return fullArea;
        }

        static string NumberToDigit(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default: throw new ArgumentException("The number you entered must be between 0 and 9!");  
            }
        }

        static int FindMax(int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentException("You must enter an array with atleast one element!");
            }

            int max = 0;

            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i]>max)
                {
                    max = elements[i];
                }
            }
            return max;
        }

        static void PrintAsNumber(object number, string format)
        {
            if (format == "f")
            {
                Console.WriteLine("{0:f2}", number);
            }
            if (format == "%")
            {
                Console.WriteLine("{0:p0}", number);
            }
            if (format == "r")
            {
                Console.WriteLine("{0,8}", number);
            }
        }


        static double CalcDistance(Point point1,Point point2)
        {
           double distance = Math.Sqrt((point2.XCoord - point1.XCoord) * (point2.XCoord - point1.XCoord) + (point2.YCoord - point1.YCoord) * (point2.YCoord - point1.YCoord));
            return distance;
        }

        static bool IsHorizontal(Line line) 
        {
            if (line.Point1.YCoord == line.Point2.YCoord)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        static bool IsVertical(Line line)
        {
            if (line.Point1.XCoord==line.Point2.XCoord)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main()
        {
            Triangle triangle = new Triangle(2,3,4);

            Console.WriteLine(CalcTriangleArea(triangle));
            
            Console.WriteLine(NumberToDigit(5));

            int[] arrayToFindMax = new int[] {5, -1, 3, 2, 14, 2, 3};
            
            Console.WriteLine(FindMax(arrayToFindMax));
            
            PrintAsNumber(1.3, "f");
            PrintAsNumber(0.75, "%");
            PrintAsNumber(2.30, "r");

            Point point1 = new Point(3,4);
            Point point2 = new Point(3, 5);
            Line line = new Line(point1,point2);

            Console.WriteLine(CalcDistance(point1,point2));
            Console.WriteLine("Horizontal? " + IsHorizontal(line));
            Console.WriteLine("Vertical? " + IsVertical(line));

            Student peter = new Student();
            peter.FirstName = "Peter";
            peter.LastName = "Ivanov";
            peter.OtherInfo = "From Sofia, born at 17.03.1992";

            Student stella = new Student();
            stella.FirstName = "Stella";
            stella.LastName = "Markova";
            stella.OtherInfo = "From Vidin, gamer, high results, born at 03.11.1993";

            Console.WriteLine("{0} older than {1} -> {2}", peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
