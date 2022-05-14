using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label4.Visible = false;
            textBox4.Visible = false;
        }
        public List<Meeting> meetings = new List<Meeting>();
        public List<Class1> class1s = new List<Class1>();
        int i = 0, j = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                label4.Visible = true;
                textBox4.Visible = true;
            }
            else
            {
                label4.Visible = false;
                textBox4.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                class1s.Add(new Class1(textBox1.Text, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text)));
                textBox6.Text += (class1s[j].ToString() + Environment.NewLine + "Qp=" + class1s[j].Q() + Environment.NewLine);
                j++;
            }
            else
            {
                meetings.Add(new Meeting(textBox1.Text, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text)));
                textBox5.Text += (meetings[i].ToString() + Environment.NewLine + "Q=" + meetings[i].Q() + Environment.NewLine);
                i++;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
