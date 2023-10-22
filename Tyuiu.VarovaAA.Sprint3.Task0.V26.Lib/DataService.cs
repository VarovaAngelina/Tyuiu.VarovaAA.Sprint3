using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.VarovaAA.Sprint3.Task0.V26.Lib
{
    public class DataService : ISprint3Task0V26
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double multiplySeries = 1;
            int i;
            for ( i = startValue; i <= stopValue; i++)
            {
                multiplySeries = multiplySeries * (((Math.Pow(2, i)) / (i + 1)) * Math.Cos(1.8));
            }
            return Math.Round(multiplySeries, 3);
        }
    }
}
