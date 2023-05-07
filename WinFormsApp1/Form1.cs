using ProjectManagement.MODEL;
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
    public partial class Form1 : Form
    {
        public Form1()
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void refresh_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            displayAllProjects();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //Form2 newForm2 = new Form2();
            //newForm2.ShowDialog();
            ListViewHitTestInfo info = listView1.HitTest(e.X, e.Y);
            ListViewItem item = info.Item;
            label1.Text = item.SubItems[0].Text;
            Form2 newForm2 = new Form2(item.SubItems[0].Text);
            newForm2.ShowDialog();
        }
    }
}
