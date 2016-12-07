using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HT1
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

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private int MCD(int m, int n)//ejemplo de mcd no es de mi autoria
        {
            if (n > m) return MCD(n, m);
            else if (n == 0) return m;
            else return MCD(m - n, n);
        }


        private void Expand()
        {
            int m, n, x, c, y;
            try
            {
                m = int.Parse(textBox1.Text);
                n = int.Parse(textBox2.Text);
                x = m * m;
                c = 2 * m * n;
                y = n * n;
                textBox3.Text = x.ToString() + "x^2 + " + c.ToString() + "x + " + y.ToString();
            }
            catch
            {
                textBox3.Text = "Error, valor invalido";
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int m = int.Parse(textBox1.Text);
                int n = int.Parse(textBox2.Text);
                textBox3.Text = MCD(m, n).ToString();
            }
            catch
            {
                textBox3.Text = "Error, valor invalido";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Expand();
        }
    }
}
