using System;
using System.Globalization;

namespace Laba2
{
    public class Income
    {
        public DateTime Date { get; set; }
        public string Source { get; set; }
        public int Sum { get; set; }

        // Преобразует входную строку в поля Income.
        public bool TryParse(string input)
        {
            try
            {
                var values = input.Split(' ');
                if (values.Length != 4 || !values[0].Equals("income",
                    StringComparison.OrdinalIgnoreCase))
                {
                    return false;
                }
                Source = values[1];
                Date = DateTime.ParseExact(values[2], "dd.MM.yyyy",
                    CultureInfo.InvariantCulture);
                Sum = int.Parse(values[3]);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public override string ToString()
        {
            return $"income {Source} {Date:dd.MM.yyyy} {Sum}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Income other)
            {
                return Source == other.Source && Date == other.Date && Sum == other.Sum;
            }
            return false;
        }

        public override int GetHashCode()
        {
            unchecked
            { // Используем "unchecked" чтобы отслеживать переполнение
                int hash = 17; // Простое число в качестве начального значения
                hash = hash * 23 + (Source?.GetHashCode() ?? 0);
                hash = hash * 23 + Date.GetHashCode();
                hash = hash * 23 + Sum.GetHashCode();
                return hash;
            }
        }
    }
}