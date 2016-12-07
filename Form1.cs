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


        private void Expand()//producto notable
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


        private void Complejos()//pasar de complejo rectangular a polar
        {
            int m, n;
            double r, t;
            try
            {
                m = int.Parse(textBox1.Text);
                n = int.Parse(textBox2.Text);
                r = Math.Sqrt(m * m + n * n);
                t = Math.Atan((double)n / m);
                textBox3.Text = "r = " + r.ToString() +" theta = " + t.ToString()+" 2012-12921";
            }catch
            {
                textBox3.Text = "Error, valor invalido";
            }
        }

        private int Factorial(int n)
        {
            if (n == 1 || n==   0)
                return 1;
            else
                return n * (n - 1);
        }

        private void Permutacion()
        {
            int m, n, r;
            r = 0;
            try
            {
                m = int.Parse(textBox1.Text);
                n = int.Parse(textBox2.Text);
                if (n <= m && n > 0 && m > 0)
                    r = Factorial(m) / Factorial(m - n);
                else
                    textBox3.Text = "Error, valor invalido para permutacion";
                textBox3.Text = r.ToString();
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

        private void button3_Click(object sender, EventArgs e)
        {
            Complejos();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Permutacion();
        }
    }
}
