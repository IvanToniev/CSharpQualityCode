using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Statistics
{
    class PrintStatistics
    {
        public void PrintStatistics(double[] array, int numberOfElementsToEvaluate)
        {
            double maxElem;
            double sumOfElements;
            for (int i = 0; i < numberOfElementsToEvaluate; i++)
            {
                if (array[i] > maxElem)
                {
                    maxElem = array[i];
                }
            }
            PrintMax(maxElem);

            sumOfElements = 0;
            maxElem = 0;
            for (int i = 0; i < numberOfElementsToEvaluate; i++)
            {
                if (array[i] < maxElem)
                {
                    maxElem = array[i];
                }
            }
            PrintMin(maxElem);

            sumOfElements = 0;
            for (int i = 0; i < numberOfElementsToEvaluate; i++)
            {
                sumOfElements += array[i];
            }
            PrintAvg(sumOfElements / numberOfElementsToEvaluate);
        }
    }
}
