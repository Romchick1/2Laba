using _2Laba;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _2Laba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Income> incomes = new List<Income>();
        List<NotIncome> notIncomes = new List<NotIncome>();

        // Формирование пути к файлу
        string basePath;
        string fullPath;


       private void listIncomes_SelectedIndexChanged(object sender, EventArgs e)
        {

       }

        private void Adding_Func(string str)
        {

        }
        private void readData_Click(object sender, EventArgs e)
        {
            basePath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            fullPath = Path.Combine(basePath, "data.txt");
            if (!File.Exists(fullPath))
            {
                label1.Text = $"Файл не найден: {fullPath}";
                return;
            }

            using (var reader = new StreamReader(fullPath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.StartsWith("income"))
                    {
                        var income = new Income();
                        income.GetData(line);
                        incomes.Add(income);
                        listIncomes.Items.Add(income.ToString());
                        Console.WriteLine(income);
                    }
                    else
                    {
                        var notIncome = new NotIncome(line);
                        notIncomes.Add(notIncome);
                        listNotIncomes.Items.Add(notIncome.ToString());
                    }
                }
            }
        }

        private void Adding_Click(object sender, EventArgs e)
        {
            if (AddBox.Text.StartsWith("income"))
            {
                var income = new Income();
                income.GetData(AddBox.Text);
                incomes.Add(income);
                listIncomes.Items.Add(income.ToString());
                Console.WriteLine(income);
            }
            else
            {
                var notIncome = new NotIncome(AddBox.Text);
                notIncomes.Add(notIncome);
                listNotIncomes.Items.Add(notIncome.ToString());
            }
            
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            //listIncomes.SelectedItems.Clear();
            foreach (ListViewItem eachItem in listIncomes.SelectedItems)
            {
                
               
              
                    var income = new Income();
                    income.GetData(eachItem.Text);
                    incomes.Remove(income);
                    listIncomes.Items.Remove(eachItem);

                
            }
            foreach (ListViewItem item in listNotIncomes.SelectedItems)
            {
                var notIncome = new NotIncome(item.Text);
                notIncomes.Remove(notIncome);
                listNotIncomes.Items.Remove(item);
            }
        }
    }
}
