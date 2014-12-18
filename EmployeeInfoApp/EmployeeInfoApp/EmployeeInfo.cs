using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeInfoApp
{
    public partial class EmployeeInfo : Form
    {
        public EmployeeInfo()
        {
            InitializeComponent();
        }
        Employee employee1 = new Employee();
        private void showButton_Click(object sender, EventArgs e)
        {
            employee1.ID = Convert.ToDouble(IDTextBox.Text);
            employee1.name = nameTextBox.Text;
            employee1.salary = Convert.ToDouble(salaryTextBox.Text);
            IDTextBox.Text = string.Empty;
            nameTextBox.Text = string.Empty;
            salaryTextBox.Text = string.Empty;
            MessageBox.Show("Employee Information \n ID : " +employee1.ID+ "\nName : " +employee1.name+ "\nSalary : " +employee1.salary);
           
        }

        private void retriveButton_Click(object sender, EventArgs e)
        {
            IDTextBox.Text = Convert.ToString(employee1.ID);
            nameTextBox.Text = employee1.name;
            salaryTextBox.Text = Convert.ToString(employee1.salary);
        }
    }
}
