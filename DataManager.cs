using _2Laba;
using System;
using System.Collections.Generic;
using System.IO;

namespace Laba2
{
    public class DataManager
    {
        private readonly List<Income> incomes_;
        private readonly List<NotIncome> not_incomes_;

        public DataManager()
        {
            incomes_ = new List<Income>();
            not_incomes_ = new List<NotIncome>();
        }

        // Adds an item (Income or NotIncome) based on the input string.
        public bool AddItem(string input)
        {
            if (input.StartsWith("income", StringComparison.OrdinalIgnoreCase))
            {
                var income = new Income();
                if (!income.TryParse(input))
                {
                    return false;
                }
                incomes_.Add(income);
                return true;
            }
            else
            {
                var not_income = new NotIncome(input);
                not_incomes_.Add(not_income);
                return true;
            }
        }

        // Removes an Income item by its string representation.
        public void RemoveIncome(string text)
        {
            var income = new Income();
            if (income.TryParse(text))
            {
                incomes_.RemoveAll(i => i.ToString() == text);
            }
        }

        // Removes a NotIncome item by its string representation.
        public void RemoveNotIncome(string text)
        {
            not_incomes_.RemoveAll(n => n.ToString() == text);
        }

        // Loads data from the specified file.
        public bool LoadFromFile(string file_path)
        {
            if (!File.Exists(file_path))
            {
                return false;
            }

            incomes_.Clear();
            not_incomes_.Clear();

            using (var reader = new StreamReader(file_path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (string.IsNullOrWhiteSpace(line))
                    {
                        continue;
                    }
                    if (line.StartsWith("income", StringComparison.OrdinalIgnoreCase))
                    {
                        var income = new Income();
                        if (income.TryParse(line))
                        {
                            incomes_.Add(income);
                        }
                    }
                    else
                    {
                        not_incomes_.Add(new NotIncome(line));
                    }
                }
            }
            return true;
        }

        // Returns the list of incomes.
        public IReadOnlyList<Income> GetIncomes()
        {
            return incomes_.AsReadOnly();
        }

        // Returns the list of not-incomes.
        public IReadOnlyList<NotIncome> GetNotIncomes()
        {
            return not_incomes_.AsReadOnly();
        }

        // Returns the default file path for data.txt.
        public static string GetDefaultFilePath()
        {
            string base_path = Directory.GetParent(Directory.GetCurrentDirectory())
                .Parent.Parent.FullName;
            return Path.Combine(base_path, "data.txt");
        }
    }
}