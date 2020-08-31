using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Information
{
    public partial class Form1 : Form
    {
        string firstName;
        string lastName;
        string motherName;
        string fatherName;
        string address;
        public Form1()
        {
            InitializeComponent();
        }
       
        private void saveButton_Click(object sender, EventArgs e)
        {
            firstName = firstNameTextBox.Text;
            lastName = lastNameTextBox.Text;
            motherName = motherNameTextBox.Text;
            fatherName = fatherNameTextBox.Text;
            address = addressTextBox.Text;

            MessageBox.Show("Save Successfully");

            Clear();
             
        }
      

        private void showAllInformationButton_Click(object sender, EventArgs e)
        {
            firstNameTextBox.Text = firstName;
            lastNameTextBox.Text = lastName;
            motherNameTextBox.Text = motherName;
            fatherNameTextBox.Text = fatherName;
            addressTextBox.Text = address;

        }

        private void showNameButton_Click(object sender, EventArgs e)
        {
            firstNameTextBox.Text = firstName;
            lastNameTextBox.Text = lastName;
            motherNameTextBox.Text = "";
            fatherNameTextBox.Text = "";
            addressTextBox.Text = "";
        }

        private void parentNameButton_Click(object sender, EventArgs e)
        {
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            motherNameTextBox.Text = motherName;
            fatherNameTextBox.Text = fatherName;
            addressTextBox.Text = "";

        }

        private void showAddressButton_Click(object sender, EventArgs e)
        {
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            motherNameTextBox.Text = "";
            fatherNameTextBox.Text = "";
            addressTextBox.Text = address;

        }

        private void Clear()
        {
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            motherNameTextBox.Text = "";
            fatherNameTextBox.Text = "";
            addressTextBox.Text = "";
        }

    }
}
