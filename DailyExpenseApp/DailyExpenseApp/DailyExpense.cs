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
using CSVLib;

namespace DailyExpenseApp
{
    public partial class DailyExpense : Form
    {
        public DailyExpense()
        {
            InitializeComponent();
        }

        private string path = @"C:\Users\LICT\Desktop\exam\dailyExpense.csv";

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (amountTextBox.Text != string.Empty && particularTextBox.Text != string.Empty)
            {
                string amount = amountTextBox.Text;
                FileStream aFileStream = new FileStream(path, FileMode.Append);
                CsvFileWriter aFileWriter = new CsvFileWriter(aFileStream);
                List<string> dailyExpense = new List<string>();
                dailyExpense.Add(amount);
                dailyExpense.Add(dailyExpenseCategorycomboBox.Text);
                dailyExpense.Add(particularTextBox.Text);
                aFileWriter.WriteRow(dailyExpense);
                aFileStream.Close();
                MessageBox.Show("Information has been added");
                amountTextBox.Text = string.Empty;
                categoryComboBox.Text = null;
                particularTextBox.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Please, provide required information");
            }

        }

        private void showExpenseButton_Click(object sender, EventArgs e)
        {
            double sum = 0,max=0;
            FileStream aFileStream = new FileStream(path,FileMode.Open);
            CsvFileReader aFileReader = new CsvFileReader(aFileStream);
            List<string> expense = new List<string>();
            while (aFileReader.ReadRow(expense) && expense[0] !=null)
            {
                double amount = Convert.ToDouble(expense[0]);
                sum += amount;
                if (amount > max)
                {
                     max=amount;
                }

            }
            totalexpenseTextBox.Text = Convert.ToString(sum);
            maximunExpenseTextBox.Text = Convert.ToString(max);
            aFileStream.Close();
        }

        private void showCategoryButton_Click(object sender, EventArgs e)
        {
            double total = 0,sum=0;
            FileStream aFileStream = new FileStream(path,FileMode.Open);
            CsvFileReader aFileReader = new CsvFileReader(aFileStream);
            List<string> categoryExpense = new List<string>();
            categoryListBox.Items.Clear();
            while (aFileReader.ReadRow(categoryExpense))
            {
             
                    string category = categoryComboBox.Text;
                    foreach (string search in categoryExpense)
                    {
                        if (categoryExpense[1].ToLower().Contains(category.ToLower()))
                        {
                            total = Convert.ToDouble(categoryExpense[0]);
                            categoryListBox.Items.Add(total+ " : " +categoryExpense[2]);
                            sum = total + sum;
                            break;
                        }
                    }
                    totalCategoryExpenseTextBox.Text = Convert.ToString(sum);
            }
            aFileStream.Close();
        }
    }
}
