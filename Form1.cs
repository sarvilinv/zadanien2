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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (txt_number.Text == null)
            {
                MessageBox.Show("Введите что-нибудь");
                Btn_ok.Enabled = false;
            }
            int number = Convert.ToInt32(txt_number.Text);
            if (number == 0)
            {
                MessageBox.Show("Как на нуль не дели всегда будет нуль.", "Совет");
            }
            else
            {
                Form2 frm2 = new Form2();

                frm2.lblnumber.Text = Convert.ToString(number);

                frm2.Show(this);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txt_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void txt_number_TextChanged(object sender, EventArgs e)
        {
            if (txt_number.Text != null)
            {
                Btn_ok.Enabled = true;
                Btn_Clear.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            txt_number.Text = null;
            Btn_ok.Enabled = false;
            Btn_Clear.Enabled = false;
        }
    }
}
