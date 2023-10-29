using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.VarovaAA.Sprint3.Task4.V25.Lib
{
    public class DataService : ISprint3Task4V25
    {
        public double Calculate(int startValue, int stopValue)
        {
            double res = 0;
            for (int x = startValue; x <= startValue; x++)
            {
                if (x == 0)
                {
                    continue;
                }
                else
                {
                    res = res + (x / (Math.Cos(x) - Math.Sin(x)));
                }
            }
            return Math.Round(res, 3);
        }
    }
}
