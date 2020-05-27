using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BfNCalculator
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

        //XP to Prize Bulbs
        private void button1_Click(object sender, EventArgs e)
        {
            string xpConvert = textBox1.Text;

            double result = 0;

            if (double.TryParse(xpConvert, out result))
            {
                double toPrizeBulb = result / 4000;
                textBox2.Text = Convert.ToString(toPrizeBulb);
            }
            else
            {
                MessageBox.Show("Please insert a number");
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        //Prize Bulb to XP
        private void button2_Click(object sender, EventArgs e)
        {
            string prizeBulbConvert = textBox2.Text;

            double result;

            if (double.TryParse(prizeBulbConvert, out result))
            {
                double toXp = result * 4000;
                textBox1.Text = Convert.ToString(toXp);
            }
            else
            {
                MessageBox.Show("Please insert a number");
                textBox1.Text = "";
                textBox2.Text = "";
            };
        }
    }
}
