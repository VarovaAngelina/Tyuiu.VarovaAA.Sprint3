using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.VarovaAA.Sprint3.Task1.V6.Lib
{
    public class DataService : ISprint3Task1V6
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double sumSeries = 0;
            while(startValue <= stopValue)
            {
                sumSeries = sumSeries + ((Math.Pow(value, startValue) + 1) * Math.Sin(startValue));
                startValue++;
            }
            return Math.Round(sumSeries, 3);
        }
    }
}
