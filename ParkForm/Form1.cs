using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox3.Text);
            MessageBox.Show((a + b).ToString());
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox3.Text);
            MessageBox.Show((a - b).ToString());

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            MessageBox.Show((a*a).ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            decimal pi= (decimal)Math.PI;
            MessageBox.Show(pi.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int sayı1= Convert.ToInt32(textBox1.Text);
            int sonuc = 1;
            for (int i =1; i<=sayı1 ; i++)
            {
                sonuc *= i;
            }
            MessageBox.Show(sonuc.ToString());

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int a= Convert.ToInt32(textBox1.Text);
            MessageBox.Show((Math.Sin(a)).ToString());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            MessageBox.Show((Math.Cos(a)).ToString());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            MessageBox.Show((Math.Tan(a)).ToString());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            MessageBox.Show((1/Math.Tan(a)).ToString());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            decimal pi= (decimal)Math.PI;
            decimal sonuc = (a * pi)/180;
            MessageBox.Show(sonuc.ToString());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            decimal pi = (decimal)Math.PI;
            decimal gradyan = Convert.ToDecimal((a * 200 ))/ pi;
            MessageBox.Show(gradyan.ToString());
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int sonuc=Math.Abs(a);
            MessageBox.Show(sonuc.ToString());
        }


    }
}
