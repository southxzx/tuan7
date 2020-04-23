using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bt_tuan7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tabControl1.SelectTab("tabPage1");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_username_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabPage1");

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabPage2");
        }
    }
}
