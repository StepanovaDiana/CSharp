using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3Laba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Phone> phones = new List<Phone>();
        SmartPhone smartphone = new SmartPhone("89155805551", 10, 1, 80, 5);
        public void output()
        {
            listBox1.Items.Clear();
            foreach(SmartPhone smartphone in phones)
            {
                listBox1.Items.Add("Смартфон: " + Environment.NewLine + "Номер телефона: " + smartphone.number + Environment.NewLine + "Кол-во контактов: " + smartphone.contacts + Environment.NewLine + "Кол-во симкарт: " + smartphone.SIMcard + Environment.NewLine + "Кол-во фото: " + smartphone.photos + Environment.NewLine + "Зарядка %: "+smartphone.percentage_charge);
            }
        }
        private void lst_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = (int)e.Graphics.MeasureString(listBox1.Items[e.Index].ToString(), listBox1.Font, listBox1.Width).Height;
        }

        private void lst_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                e.DrawBackground();
                e.DrawFocusRectangle();
                e.Graphics.DrawString(listBox1.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.listBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.listBox1.MeasureItem += lst_MeasureItem;
            this.listBox1.DrawItem += lst_DrawItem;
            button9.Visible = false;
            button10.Visible = false;
            label6.Visible = false;
            textBox5.Visible = false;
            label7.Visible = false;
            textBox6.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            phones.Add(new SmartPhone(textBox1.Text, Convert.ToInt32(textBox2.Text), Convert.ToInt32(comboBox1.SelectedItem), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text)));
            output();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                if (phones.Count > 0)
                {
                    phones.RemoveAt(listBox1.SelectedIndex);
                    output();
                }
                else
                {
                    MessageBox.Show("Список пуст!");
                }
            }
            else
            {
                MessageBox.Show("Вы не выбрали элемент listBox");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                ((SmartPhone)phones[listBox1.SelectedIndex]).add_contacts(textBox6.Text);
                output();
                label7.Visible = false;
                textBox6.Visible = false;
                button10.Visible = false;
            }
            else
            {
                MessageBox.Show("Вы не выбрали элемент listBox");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button9.Visible = true;
            textBox5.Visible = true;
            label6.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                ((SmartPhone)phones[listBox1.SelectedIndex]).call(textBox5.Text);
                output();
                label6.Visible = false;
                textBox5.Visible = false;
                button9.Visible = false;
            }
            else
            {
                MessageBox.Show("Вы не выбрали элемент listBox");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                ((SmartPhone)phones[listBox1.SelectedIndex]).take_call();
            }
            else
            {
                MessageBox.Show("Вы не выбрали элемент listBox");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                ((SmartPhone)phones[listBox1.SelectedIndex]).take_photo();
                output();
            }
            else
            {
                MessageBox.Show("Вы не выбрали элемент listBox");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button10.Visible = true;
            label7.Visible = true;
            textBox6.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                ((SmartPhone)phones[listBox1.SelectedIndex]).insert_simcard();
                output();
            }
            else
            {
                MessageBox.Show("Вы не выбрали элемент listBox");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                ((SmartPhone)phones[listBox1.SelectedIndex]).charge_phone();
                output();
            }
            else
            {
                MessageBox.Show("Вы не выбрали элемент listBox");
            }
        }
    }
}
