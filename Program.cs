using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _2Laba
{
     static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
           

            // Пример создания объекта вручную
            var income1 = new Income
            {
                Date = new DateTime(2024, 2, 21),
                Source = "Some Company",
                Summ = 12
            };

            Console.WriteLine(income1);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}







