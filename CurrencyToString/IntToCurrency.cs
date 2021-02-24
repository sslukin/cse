using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyToString
{
    static class IntToCurrency
    {
        public static string Convert(this int n)
        {
            List<string> result = new List<string>();

            int d1, d2, d3, d23;
            d1 = (n - n % 100) / 100;
            d23 = n - (d1 * 100);
            d3 = d23 % 10;
            d2 = (d23 - d3) / 10;

            string[] arrD1 = ",сто,двести,триста,четыреста,пятьсот,шестьсот,семьсот,восемьсот,девятьсот".Split(",");
            if (d1 > 0) result.Add(arrD1[d1]);

            string[] arrD2 = ",десять,двадцать,тридцать,сорок,пятьдесят,шестьдесят,семьдесят,восемьдесят,девяносто".Split(",");
            if (d23 > 10 && d23 < 20)
            {
                string[] arrD23 = ",одиннадцать,двенадцать,тринадцать,четырнадцать,пятнадцать,шестнадцать,семнадцать,восемнадцать,девятнадцать".Split(",");
                result.Add(arrD23[d3]);
            }
            else
            {
                if (d2 > 0) result.Add(arrD2[d2]);

                string[] arrD3 = ",один,два,три,четыре,пять,шесть,семь,восемь,девять".Split(",");
                if (d3 > 0) result.Add(arrD3[d3]);
            }

            string rub;
            if (d3 == 1 && d2 != 1)
                rub = "рубль";
            else if ((d3 == 2 || d3 == 3 || d3 == 4) && d2 != 1)
                rub = "рубля";
            else
                rub = "рублей";

            result.Add(rub);

            return String.Join(" ", result);
        }
    }
}
