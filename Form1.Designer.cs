namespace Laba2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listIncomes = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.readData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Adding = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.AddBox = new System.Windows.Forms.TextBox();
            this.listNotIncomes = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listIncomes
            // 
            this.listIncomes.HideSelection = false;
            this.listIncomes.Location = new System.Drawing.Point(28, 70);
            this.listIncomes.Name = "listIncomes";
            this.listIncomes.Size = new System.Drawing.Size(395, 352);
            this.listIncomes.TabIndex = 0;
            this.listIncomes.UseCompatibleStateImageBehavior = false;
            this.listIncomes.View = System.Windows.Forms.View.List;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(290, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "C:\\Users\\shvet\\source\\repos\\data.txt";
            // 
            // readData
            // 
            this.readData.Location = new System.Drawing.Point(324, 9);
            this.readData.Name = "readData";
            this.readData.Size = new System.Drawing.Size(86, 25);
            this.readData.TabIndex = 2;
            this.readData.Text = "read data";
            this.readData.UseVisualStyleBackColor = true;
            this.readData.Click += new System.EventHandler(this.readData_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // Adding
            // 
            this.Adding.Location = new System.Drawing.Point(454, 44);
            this.Adding.Name = "Adding";
            this.Adding.Size = new System.Drawing.Size(125, 20);
            this.Adding.TabIndex = 4;
            this.Adding.Text = "Add item";
            this.Adding.UseVisualStyleBackColor = true;
            this.Adding.Click += new System.EventHandler(this.Adding_Click);
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(625, 43);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(123, 20);
            this.Remove.TabIndex = 5;
            this.Remove.Text = "Remove selected item";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // AddBox
            // 
            this.AddBox.Location = new System.Drawing.Point(429, 12);
            this.AddBox.Name = "AddBox";
            this.AddBox.Size = new System.Drawing.Size(297, 20);
            this.AddBox.TabIndex = 6;
            this.AddBox.Text = "income Sharipovo 13.02.2025 153";
            // 
            // listNotIncomes
            // 
            this.listNotIncomes.HideSelection = false;
            this.listNotIncomes.Location = new System.Drawing.Point(429, 70);
            this.listNotIncomes.Name = "listNotIncomes";
            this.listNotIncomes.Size = new System.Drawing.Size(344, 351);
            this.listNotIncomes.TabIndex = 7;
            this.listNotIncomes.UseCompatibleStateImageBehavior = false;
            this.listNotIncomes.View = System.Windows.Forms.View.List;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listNotIncomes);
            this.Controls.Add(this.AddBox);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Adding);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.readData);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listIncomes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listIncomes;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button readData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Adding;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.TextBox AddBox;
        private System.Windows.Forms.ListView listNotIncomes;
    }
}

