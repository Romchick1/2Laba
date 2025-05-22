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

        // Handles the click event for the "Read Data" button.
        private void ReadDataClick(object sender, EventArgs e)
        {
            string file_path = GetFilePath();
            if (!data_manager_.LoadFromFile(file_path))
            {
                ShowError($"File not found: {file_path}");
                return;
            }
            UpdateLists();
        }

        // Handles the click event for the "Add Item" button.
        private void AddItemClick(object sender, EventArgs e)
        {
            string input = AddBox.Text.Trim();
            if (string.IsNullOrEmpty(input))
            {
                ShowError("Input cannot be empty.");
                return;
            }

            if (!data_manager_.AddItem(input))
            {
                ShowError("Invalid input format.");
                return;
            }
            UpdateLists();
            AddBox.Clear();
        }

        // Handles the click event for the "Remove Selected Item" button.
        private void RemoveSelectedItemClick(object sender, EventArgs e)
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
                ShowError("No items selected.");
                return;
            }
            UpdateLists();
        }

        // Returns the file path from textBox1 or the default path.
        private string GetFilePath()
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                return DataManager.GetDefaultFilePath();
            }
            return textBox1.Text;
        }

        // Updates the ListView controls with current data.
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

        // Displays an error message to the user.
        private void ShowError(string message)
        {
            label1.Text = message;
        }

        private void readData_Click(object sender, EventArgs e)
        {
            string file_path = GetFilePath();
            if (!data_manager_.LoadFromFile(file_path))
            {
                ShowError($"File not found: {file_path}");
                return;
            }
            UpdateLists();
        }

        private void Adding_Click(object sender, EventArgs e)
        {
            string input = AddBox.Text.Trim();
            if (string.IsNullOrEmpty(input))
            {
                ShowError("Input cannot be empty.");
                return;
            }

            if (!data_manager_.AddItem(input))
            {
                ShowError("Invalid input format.");
                return;
            }
            UpdateLists();
            AddBox.Clear();
        }

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
                ShowError("No items selected.");
                return;
            }
            UpdateLists();
        }
    }
}