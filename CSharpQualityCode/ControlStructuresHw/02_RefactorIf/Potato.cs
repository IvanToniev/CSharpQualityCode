using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_RefactorIf
{
    class Potato
    {
        static void Main(string[] args)
        {
            Potato potato;
            if (potato != null) 
            {
                if (potato.HasBeenPeeled && potato.IsNotRotten)
                {
                    Cook(potato);
                }
            }
            if (x>=minX && (x <= maxX && (YBetweenMaxAndMin(y, maxY, minY) && shouldVisitCell)))
	        {
		        VisitCell();
	        }
        }

        private bool YBetweenMaxAndMin(int y, int maxY, int minY)
        {
            if (maxY >= y && minY <= y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
