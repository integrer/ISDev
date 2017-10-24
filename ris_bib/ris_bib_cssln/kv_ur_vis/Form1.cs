using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kv_ur_vis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender=null, EventArgs e=null)
        {
            lNoslove.Visible = lx1.Visible = lx2.Visible = false;
            double a, b, c, D;
            try {
                a = Double.Parse(fielda.Text);
                b = Double.Parse(fieldb.Text);
                c = Double.Parse(fieldc.Text);
            
            D = Math.Pow(b, 2) - 4 * a * c;
            if (D < 0) {
                lNoslove.Visible = true;
                return;
            }
            D = Math.Sqrt(D);
            lx1.Text = "x1 = " + (-b - D) / 2 * a;
            lx2.Text = "x2 = " + (-b + D) / 2 * a;
            lx1.Visible = lx2.Visible = true;
            }
            catch (Exception err)
            {
                MessageBox.Show("Неверный ввод!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                fielda.Text = fieldb.Text = fieldc.Text = "";
            }
        }

        private void getFocusTB(object sender, EventArgs e) {
            TextBox temp = (TextBox)sender;
            temp.Text = "";
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e) {
            switch (e.KeyChar) {
                case '\n': button1_Click(); break;
                default: break;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox(e.KeyValue);
            switch (e.KeyValue)
            {
                case '\n': button1_Click(); break;
                default: break;
            }
        }
    }
}
