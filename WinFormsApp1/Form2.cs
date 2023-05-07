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
            //Status status = new Status();
            //status.Status1 = "orlando";
            //StatusRepository statusRepository = new StatusRepository();
            //statusRepository.Add(status);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Form1 home = new Form1();
            //home.Show();
            this.Close();
        }
    }
}
