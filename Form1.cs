using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Laba2
{
    public partial class Form1 : Form
    {
        private readonly DataManager data_manager_;

        public Form1()
        {
            InitializeComponent();
            data_manager_ = new DataManager();
        }


        // Получает путь к файлу
        private string GetFilePath()
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                return DataManager.GetDefaultFilePath();
            }
            return textBox1.Text;
        }

        // Обновляет содержимое ListView
        private void UpdateLists()
        {
            listIncomes.Items.Clear();
            listNotIncomes.Items.Clear();

            foreach (var income in data_manager_.GetIncomes())
            {
                listIncomes.Items.Add(income.ToString());
            }
            foreach (var not_income in data_manager_.GetNotIncomes())
            {
                listNotIncomes.Items.Add(not_income.ToString());
            }
        }

        // Вывод ошибок
        private void ShowError(string message)
        {
            label1.Text = message;
        }

        // Обработчик для кнопки Чтения данных из файла
        private void readData_Click(object sender, EventArgs e)
        {
            string file_path = GetFilePath();
            if (!data_manager_.LoadFromFile(file_path))
            {
                ShowError($"Файл не найден {file_path}");
                return;
            }
            UpdateLists();
        }

        // Обработчик для кнопки добавления item
        private void Adding_Click(object sender, EventArgs e)
        {
            string input = AddBox.Text.Trim();
            if (string.IsNullOrEmpty(input))
            {
                ShowError("Введите данные");
                return;
            }

            if (!data_manager_.AddItem(input))
            {
                ShowError("Неверный формат входных данных");
                return;
            }
            UpdateLists();
            AddBox.Clear();
        }


        // Обработчик для кнопки удаления
        private void Remove_Click(object sender, EventArgs e)
        {
            bool items_removed = false;
            foreach (ListViewItem item in listIncomes.SelectedItems)
            {
                data_manager_.RemoveIncome(item.Text);
                items_removed = true;
            }
            foreach (ListViewItem item in listNotIncomes.SelectedItems)
            {
                data_manager_.RemoveNotIncome(item.Text);
                items_removed = true;
            }

            if (!items_removed)
            {
                ShowError("Сначала выберите что-нибуть");
                return;
            }
            UpdateLists();
        }
    }
}