using System;
using System.Collections.Generic;
using System.Globalization;

namespace _2Laba
{
    class Income
    {
        public DateTime Date { get; set; }
        public string Source { get; set; }
        public int Summ { get; set; }

        public void GetData(string str)
        {
            var values = new List<string>(str.Split(' '));
            Date = DateTime.ParseExact(values[2], "dd.MM.yyyy", CultureInfo.InvariantCulture);
            Source = values[1];
            Summ = int.Parse(values[3]);
        }

        public override string ToString()
        {
            return $"income {Source} {Date:dd.MM.yyyy} {Summ}";
        }
    }//
}