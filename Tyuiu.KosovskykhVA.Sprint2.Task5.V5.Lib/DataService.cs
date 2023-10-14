using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KosovskykhVA.Sprint2.Task5.V5.Lib
{
    public class DataService : ISprint2Task5V5
    {
        public string FindCardValue(int value)
        {
            string card = "";
            switch (value)
            {
                case 6:
                    card = "Шестерка";
                    break;
                case 7:
                    card = "Семерка";
                    break;
                case 8:
                    card = "Восьмерка";
                    break;
                case 9:
                    card = "Девятка";
                    break;
                case 10:
                    card = "Десятка";
                    break;
                case 11:
                    card = "Валет";
                    break;
                case 12:
                    card = "Дама";
                    break;
                case 13:
                    card = "Король";
                    break;
                case 14:
                    card = "Туз";
                    break;
            }
            return card;
        }
    }
}
