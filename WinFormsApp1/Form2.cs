using Microsoft.IdentityModel.Tokens;
using ProjectManagement.BLL;
using ProjectManagement.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectManagement.APP
{
    public partial class Form2 : Form
    {
        private string listViewItemId;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string listViewItemId)
        {
            InitializeComponent();
            this.listViewItemId = listViewItemId;
            ProjectRepository projectRepository = new ProjectRepository();
            StatusRepository statusRepository = new StatusRepository();
            Project selectedProject = projectRepository.GetById(int.Parse(listViewItemId));
            projectNameTextBox.Text = selectedProject.ProjectName.ToString();
            managerNameTextBox.Text = selectedProject.ManagerName.ToString();
            startDateTimePicker.Value = DateTime.Parse(selectedProject.StartDate);
            finishDateTimePicker.Value = DateTime.Parse(selectedProject.FinishDate);
            summaryTextBox.Text = selectedProject.Summary.ToString();
            statusComboBox.Text = statusRepository.GetById(int.Parse(selectedProject.IdStatus.ToString())).Status1.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            ProjectRepository projectRepository = new ProjectRepository();
            StatusRepository statusRepository = new StatusRepository();
            Project project = new Project();

            if (string.IsNullOrEmpty(statusComboBox.Text))
            {
                return;
            }

            var status = statusRepository.GetIdByStatusName(statusComboBox.Text);
            project.IdStatus = status.Id;
            project.ProjectName = projectNameTextBox.Text;
            project.ManagerName = managerNameTextBox.Text;
            project.StartDate = startDateTimePicker.Value.ToString();
            project.FinishDate = finishDateTimePicker.Value.ToString();
            project.Summary = summaryTextBox.Text;

            var allProjects = projectRepository.GetAll();

            bool itExists = false;
            int j = 0;

            for (int i = 0; i < allProjects.Count; i++)
            {
                if (project.ProjectName == allProjects[i].ProjectName)
                {
                    j = i;
                    itExists = true;
                    break;
                }
            }

            if (itExists)
            {
                project.Id = allProjects[j].Id;
                projectRepository.Update(project);
                MessageBox.Show("Project Successfully Updated");
            }
            else
            {
                try
                {
                    projectRepository.Add(project);
                    MessageBox.Show("Project Successfully Added");
                }catch(InvalidOperationException)
                {
                    MessageBox.Show("Unable to add project.");
                }

            }

            //closing window
            this.Close();
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

        private void startDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void managerNameTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void finishDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
