﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KosovskykhVA.Sprint2.Task3.V12.Lib
{
    public class DataService : ISprint2Task3V12
    {
        public double Calculate(double x)
        {
            double y;

            if (x > 1)
            {
                y = x + Math.Pow(((x + 1) / (x - 1)), x);
            }
            else if (x == 0)
            {
                y = 1 + Math.Cos(Math.Sqrt(x + 1));
            }
            else if ((-16 < x) && (x < 2))
            {
                y = Math.Pow((7 + 5 / Math.Pow(x, 2)), x);
            }
            else
            {
                y = 10 * x - (1 / x);
            }

            return Math.Round(y, 3);
        }
    }
}
