﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KosovskykhVA.Sprint2.Task4.V21.Lib
{
    public class DataService : ISprint2Task4V21
    {
        public double Calculate(double x, double y)
        {
            double z = (x < y - 2) ? (Math.Pow((2 + (x + 1) / Math.Pow(x, 2)), y)) : ((x * x + 10) / (Math.Pow(y, 2) - (Math.Sin(Math.Pow(x, 2))) + 12));
            return Math.Round(z, 3);
        }
    }
}
