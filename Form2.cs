using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanien2
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
            lblResult.ForeColor = Color.Black;
            this.BackColor = Color.White;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            for (int i = 1;i != 11; i++)
            {
                lblResult.Text += Convert.ToString(lblnumber.Text + " * " + i + " = " + (Convert.ToInt32(lblnumber.Text) * i) + "\n");
            }
        }

        private void красныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void оранжевыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Orange;
        }

        private void жёлтыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void зелёныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void голубойToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Cyan;
        }

        private void синийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void фиолетовыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Violet;
        }

        private void белыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void черныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
        }

        private void розовыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Pink;
        }

        private void красныйToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lblResult.ForeColor = Color.Red;
        }

        private void оранжевыйToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lblResult.ForeColor = Color.Orange;
        }

        private void желтыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblResult.ForeColor = Color.Yellow;
        }

        private void зелёныйToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lblResult.ForeColor = Color.Green;
        }

        private void голубойToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lblResult.ForeColor = Color.Cyan;
        }

        private void синийToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lblResult.ForeColor = Color.Blue;
        }

        private void фиолетовыйToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lblResult.ForeColor = Color.Violet;
        }

        private void белыйToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lblResult.ForeColor = Color.White;
        }

        private void черныйToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lblResult.ForeColor = Color.Black;
        }

        private void розовыйToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lblResult.ForeColor = Color.Pink;
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
