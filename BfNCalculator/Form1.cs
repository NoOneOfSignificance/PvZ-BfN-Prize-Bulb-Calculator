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

        double BulbCount;

        //XP to Prize Bulbs
        private void button1_Click(object sender, EventArgs e)
        {
            string xpConvert = textBox1.Text;

            double result = 0;

            if (double.TryParse(xpConvert, out result))
            {
                double toPrizeBulb = result / 4000;
                textBox2.Text = Convert.ToString(toPrizeBulb);
                BulbCount = toPrizeBulb;
                textBox3.Text = Convert.ToString(getStars(BulbCount));
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
                BulbCount = result;
                double toXp = result * 4000;
                textBox1.Text = Convert.ToString(toXp);
                textBox3.Text = Convert.ToString(getStars(BulbCount));
            }
            else
            {
                MessageBox.Show("Please insert a number");
                textBox1.Text = "";
                textBox2.Text = "";
            };
        }

        int getStars(double bulbCount)
        {
            int bulbsFive = 250;
            int bulbsTen = 450;
            int bulbsTwenty = 800;
            int result;

            if (BulbCount <= 5)
            {
                return bulbsFive;
            }
            else if (BulbCount <= 10 && BulbCount > 5)
            {
                return bulbsTen;
            }
            else if (BulbCount <= 15 && BulbCount > 10)
            {
                result = bulbsFive + bulbsTen;
                return result;
            }
            else if (BulbCount <= 20 && BulbCount > 15)
            {
                return bulbsTwenty;
            }
            else if (BulbCount <= 25 && BulbCount > 20)
            {
                result = bulbsFive + bulbsTwenty;
                return result;
            }
            else if (BulbCount <= 30 && BulbCount > 25)
            {
                result = bulbsTen + bulbsTwenty;
                return result;

            }
            else if (BulbCount <= 35 && BulbCount > 30)
            {
                result = bulbsFive + bulbsTen + bulbsTwenty;
                return result;

            }
            else if (BulbCount <= 40 && BulbCount > 35)
            {
                result = bulbsTwenty + bulbsTwenty;
                return result;
            }
            else if (BulbCount <= 45 && BulbCount > 40)
            {
                result = bulbsTwenty + bulbsTwenty + bulbsFive;
                return result;
            }
            else if (BulbCount <= 50 && BulbCount > 45)
            {
                result = bulbsTwenty + bulbsTwenty + bulbsTen;
                return result;
            }
            return 0;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
