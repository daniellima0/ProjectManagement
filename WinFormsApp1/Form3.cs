using ProjectManagement.BLL;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void deleteTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(deleteTextBox.Text, out var convertedValue))
            {
                e.Cancel = true;
                deleteTextBox.Focus();
                errorProvider.SetError(deleteTextBox, "Please insert a valid number");
            }
            else if (string.IsNullOrEmpty(deleteTextBox.Text))
            {
                e.Cancel = true;
                deleteTextBox.Focus();
                errorProvider.SetError(deleteTextBox, "Please fill this field");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(deleteTextBox, null);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(deleteTextBox.Text, out var convertedValue))
                {
                    return;
                }
                int projectId = int.Parse(deleteTextBox.Text);
                ProjectRepository projectRepository = new ProjectRepository();
                projectRepository.Delete(projectRepository.GetById(projectId));
                MessageBox.Show("Project Deleted.");
                this.Close();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Unable to Delete.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
