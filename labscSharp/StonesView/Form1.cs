using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1_лаба;
namespace StonesView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        IDecorations necklace = new Necklace();
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            label2.Text = "0";
            label3.Text = "0";
            Creator[] creators = new Creator[2];
            creators[0] = new GemsCreator();
            creators[1] = new SemipreciousStonesCreator();
            foreach (Creator i in creators)
            {
                if (i is GemsCreator)
                {
                    necklace.Add(i.FactoryMethod("Алмаз", 0.02, 26000.98, 87));
                    necklace.Add(i.FactoryMethod("Сапфир", 0.05, 15000.23, 76));
                }

                if (i is SemipreciousStonesCreator)
                {
                    necklace.Add(i.FactoryMethod("Лазурит", 1.5, 120, 25));
                    necklace.Add(i.FactoryMethod("Глауконит", 1.0, 1.8, 28));
                }
            }

            necklace.Sort();
            textBox1.Text = "Отсортированные камни: " + Environment.NewLine;        
            foreach(var i in necklace.Items)
            {
                textBox1.Text += "Название камня: " + i.Name + " Вес: " + i.Weight + " Цена: " + i.Price + " Параметр прозрачности: " + i.TransparencyParameter + Environment.NewLine;

            }
            textBox1.Text+=Environment.NewLine+ ("Вес ожерелья: "+ necklace.NecklaceWeight()+" Стоимость: "+necklace.NecklacePrice());
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label2.Text = trackBar1.Value.ToString();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            label3.Text = trackBar2.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            foreach(var i in necklace.FindNecklaceByTransparencyParameter(trackBar1.Value,trackBar2.Value))
            {
                textBox2.Text += ("Название камня: " + i.Name + " Прозрачность: " + i.TransparencyParameter) + Environment.NewLine;
            }
        }
    }
}
