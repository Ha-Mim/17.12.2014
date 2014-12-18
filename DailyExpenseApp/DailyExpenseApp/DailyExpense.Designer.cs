namespace DailyExpenseApp
{
    partial class DailyExpense
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.particularTextBox = new System.Windows.Forms.TextBox();
            this.dailyExpenseCategorycomboBox = new System.Windows.Forms.ComboBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.showExpenseButton = new System.Windows.Forms.Button();
            this.totalexpenseTextBox = new System.Windows.Forms.TextBox();
            this.maximunExpenseTextBox = new System.Windows.Forms.TextBox();
            this.showCategoryButton = new System.Windows.Forms.Button();
            this.categoryListBox = new System.Windows.Forms.ListBox();
            this.totalCategoryExpenseTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Daily Expense Entry";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Particular";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "View Summary";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total Expense";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Maximum Expense";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(430, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "View Categorywise Expense";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(430, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Category";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(514, 291);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Total";
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(131, 39);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(100, 20);
            this.amountTextBox.TabIndex = 10;
            // 
            // particularTextBox
            // 
            this.particularTextBox.Location = new System.Drawing.Point(131, 95);
            this.particularTextBox.Multiline = true;
            this.particularTextBox.Name = "particularTextBox";
            this.particularTextBox.Size = new System.Drawing.Size(146, 55);
            this.particularTextBox.TabIndex = 12;
            // 
            // dailyExpenseCategorycomboBox
            // 
            this.dailyExpenseCategorycomboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "House Rent",
            "Utility Bill",
            "Conveyance",
            "Grocery",
            "Misc"});
            this.dailyExpenseCategorycomboBox.FormattingEnabled = true;
            this.dailyExpenseCategorycomboBox.Items.AddRange(new object[] {
            "House Rent",
            "Utility Bill",
            "Conveyance",
            "Grocery",
            "Misc"});
            this.dailyExpenseCategorycomboBox.Location = new System.Drawing.Point(131, 65);
            this.dailyExpenseCategorycomboBox.Name = "dailyExpenseCategorycomboBox";
            this.dailyExpenseCategorycomboBox.Size = new System.Drawing.Size(121, 21);
            this.dailyExpenseCategorycomboBox.TabIndex = 13;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "House Rent",
            "Utility Bill",
            "Conveyance",
            "Grocery",
            "Misc"});
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Items.AddRange(new object[] {
            "House Rent",
            "Utility Bill",
            "Conveyance",
            "Grocery",
            "Misc"});
            this.categoryComboBox.Location = new System.Drawing.Point(517, 56);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(121, 21);
            this.categoryComboBox.TabIndex = 14;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(244, 168);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 15;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // showExpenseButton
            // 
            this.showExpenseButton.Location = new System.Drawing.Point(244, 210);
            this.showExpenseButton.Name = "showExpenseButton";
            this.showExpenseButton.Size = new System.Drawing.Size(75, 23);
            this.showExpenseButton.TabIndex = 16;
            this.showExpenseButton.Text = "Show";
            this.showExpenseButton.UseVisualStyleBackColor = true;
            this.showExpenseButton.Click += new System.EventHandler(this.showExpenseButton_Click);
            // 
            // totalexpenseTextBox
            // 
            this.totalexpenseTextBox.Location = new System.Drawing.Point(131, 249);
            this.totalexpenseTextBox.Name = "totalexpenseTextBox";
            this.totalexpenseTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalexpenseTextBox.TabIndex = 17;
            // 
            // maximunExpenseTextBox
            // 
            this.maximunExpenseTextBox.Location = new System.Drawing.Point(131, 292);
            this.maximunExpenseTextBox.Name = "maximunExpenseTextBox";
            this.maximunExpenseTextBox.Size = new System.Drawing.Size(100, 20);
            this.maximunExpenseTextBox.TabIndex = 18;
            // 
            // showCategoryButton
            // 
            this.showCategoryButton.Location = new System.Drawing.Point(600, 95);
            this.showCategoryButton.Name = "showCategoryButton";
            this.showCategoryButton.Size = new System.Drawing.Size(75, 23);
            this.showCategoryButton.TabIndex = 19;
            this.showCategoryButton.Text = "Show";
            this.showCategoryButton.UseVisualStyleBackColor = true;
            this.showCategoryButton.Click += new System.EventHandler(this.showCategoryButton_Click);
            // 
            // categoryListBox
            // 
            this.categoryListBox.FormattingEnabled = true;
            this.categoryListBox.Location = new System.Drawing.Point(451, 138);
            this.categoryListBox.Name = "categoryListBox";
            this.categoryListBox.Size = new System.Drawing.Size(224, 95);
            this.categoryListBox.TabIndex = 20;
            // 
            // totalCategoryExpenseTextBox
            // 
            this.totalCategoryExpenseTextBox.Location = new System.Drawing.Point(575, 285);
            this.totalCategoryExpenseTextBox.Name = "totalCategoryExpenseTextBox";
            this.totalCategoryExpenseTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalCategoryExpenseTextBox.TabIndex = 21;
            // 
            // DailyExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 335);
            this.Controls.Add(this.totalCategoryExpenseTextBox);
            this.Controls.Add(this.categoryListBox);
            this.Controls.Add(this.showCategoryButton);
            this.Controls.Add(this.maximunExpenseTextBox);
            this.Controls.Add(this.totalexpenseTextBox);
            this.Controls.Add(this.showExpenseButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.dailyExpenseCategorycomboBox);
            this.Controls.Add(this.particularTextBox);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DailyExpense";
            this.Text = "Daily Expense";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.TextBox particularTextBox;
        private System.Windows.Forms.ComboBox dailyExpenseCategorycomboBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button showExpenseButton;
        private System.Windows.Forms.TextBox totalexpenseTextBox;
        private System.Windows.Forms.TextBox maximunExpenseTextBox;
        private System.Windows.Forms.Button showCategoryButton;
        private System.Windows.Forms.ListBox categoryListBox;
        private System.Windows.Forms.TextBox totalCategoryExpenseTextBox;
    }
}

