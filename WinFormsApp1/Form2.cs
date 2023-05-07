using Microsoft.IdentityModel.Tokens;
using ProjectManagement.BLL;
using ProjectManagement.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManagement.APP
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            

            //closing window
            //this.Close();
        }

        private void cancelButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void projectNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void summaryTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void statusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            StatusRepository sr = new StatusRepository();

            sr.GetAll().ForEach(ts =>
            {
                if (!statusComboBox.Items.Contains(ts.Status1))
                {
                    statusComboBox.Items.Add(ts.Status1);
                }
            });
        }

        private void projectNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(projectNameTextBox.Text))
            {
                e.Cancel = true;
                projectNameTextBox.Focus();
                errorProvider.SetError(projectNameTextBox, "Please fill this field");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(projectNameTextBox, null);
            }
        }

        private void managerNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(managerNameTextBox.Text))
            {
                e.Cancel = true;
                managerNameTextBox.Focus();
                errorProvider.SetError(managerNameTextBox, "Please fill this field");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(managerNameTextBox, null);
            }
        }

        private void summaryTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(summaryTextBox.Text))
            {
                e.Cancel = true;
                summaryTextBox.Focus();
                errorProvider.SetError(summaryTextBox, "Please fill this field");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(summaryTextBox, null);
            }
        }

        private void statusComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(statusComboBox.Text))
            {
                e.Cancel = true;
                statusComboBox.Focus();
                errorProvider.SetError(statusComboBox, "Please fill this field");
            }
            //else if (statusComboBox.Text != "not started" || statusComboBox.Text != "in progress" || statusComboBox.Text != "completed")
            //{
            //    e.Cancel = true;
            //    statusComboBox.Focus();
            //    errorProvider.SetError(statusComboBox, "Fill this field with valid values");
            //}
            else
            {
                e.Cancel = false;
                errorProvider.SetError(statusComboBox, null);
            }
        }

        private void finishDateTimePicker_Validating(object sender, CancelEventArgs e)
        {
            if (DateTime.Compare(finishDateTimePicker.Value, startDateTimePicker.Value) < 0)
            {
                e.Cancel = true;
                finishDateTimePicker.Focus();
                errorProvider.SetError(finishDateTimePicker, "Please choose a finish date greater than the start date");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(finishDateTimePicker, null);
            }
        }
    }
}
