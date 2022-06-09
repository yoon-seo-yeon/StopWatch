using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopWatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void 나만의스토ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender; 

            lblStatus.Text += "+";
            tbStatus.Text += "+";
            if(timer1.Enabled == false)
            {
                timer1.Enabled = true;
                elapsedTime = 0;
                toolStripProgressBar1.Value = 0; ;
                lblStatus.Text = "";
                tbStatus.Text = "";

            }
            else
            {
                timer1.Enabled = false;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            elapsedTime++;
            lblStatus.Text = elapsedTime + "초 경과";
            tbStatus.Text = elapsedTime + "초 경과";
            toolStripProgressBar1.Value = elapsedTime;
        }

        private int elapsedTime = 0;
    }
}
