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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectManagement.APP
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            displayAllProjects();
        }

        private void displayAllProjects()
        {
            var projectRepository = new ProjectRepository();
            var statusRepository = new StatusRepository();
            var allProjects = projectRepository.GetAll();

            foreach (var project in allProjects)
            {
                ListViewItem listViewItem = new ListViewItem();

                listViewItem.Text = project.Id.ToString(); // Set the first column (id)
                listViewItem.SubItems.Add(project.ProjectName.ToString());
                listViewItem.SubItems.Add(project.ManagerName.ToString());
                listViewItem.SubItems.Add(project.StartDate.ToString());

                if (project.FinishDate == null)
                {
                    listViewItem.SubItems.Add("");
                }
                else
                {
                    listViewItem.SubItems.Add(project.FinishDate.ToString());
                }

                var status = statusRepository.GetById(project.IdStatus);
                listViewItem.SubItems.Add(status.Status1.ToString());

                listView1.Items.Add(listViewItem);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = listView1.HitTest(e.X, e.Y);
            ListViewItem item = info.Item;
            Form2 newForm2 = new Form2(item.SubItems[0].Text);
            newForm2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            displayAllProjects();
        }
    }
}
