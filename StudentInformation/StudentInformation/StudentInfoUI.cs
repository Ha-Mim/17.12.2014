using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformation
{
    public partial class StudentInfoUI : Form
    {
        public StudentInfoUI()
        {
            InitializeComponent();
        }

        Student aStudent = new Student();
        private void showButton_Click(object sender, EventArgs e)
        {
            aStudent.regNo = regNoTextBox.Text;
            aStudent.firstName = firstNameTextBox.Text;
            aStudent.lastName = lastNameTextBox.Text;
            ClearTestBoxes();
            string fullName = aStudent.GetFullName();
            MessageBox.Show(fullName + ", Your reg No. is " + aStudent.regNo);
        }

        public void ClearTestBoxes()
        {
            regNoTextBox.Text = string.Empty;
            firstNameTextBox.Text = string.Empty;
            lastNameTextBox.Text = string.Empty;
        }

        private void retriveButton_Click(object sender, EventArgs e)
        {
            regNoTextBox.Text = aStudent.regNo;
            firstNameTextBox.Text = aStudent.firstName;
            lastNameTextBox.Text = aStudent.lastName;
        }
    }
}
