using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CalenderApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            btnExit.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_currentDay.Text = DateTime.Now.Day.ToString();
            lbl_currentYear.Text = DateTime.Now.Year.ToString();
        }
    }
}
