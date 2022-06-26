using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3Laba
{
    public interface Phone
    {
        string number { get; set; }
        void call(string s);
        void take_call();


    }
    public abstract class Mobile_phone : Phone
    {
        public string number { get; set; }
        public int contacts { get; set; }
        public int SIMcard { get; set; }

        public Mobile_phone(string number, int contacts, int simcard)
        {
            this.number = number;
            this.contacts = contacts;
            this.SIMcard = simcard;
        }

        public void call(string s)
        {
            if (s != "")
                MessageBox.Show("Вы позвонили на номер " + s);
            else
                MessageBox.Show("Вы не набрали номер ");

        }
        public void take_call()
        {
            MessageBox.Show("Вы приняли звонок ");
        }
        public void add_contacts(string s)
        {
            if (s != "")
            {
                contacts++;
                MessageBox.Show("Вы добавили контакт ");
            }
            else
                MessageBox.Show("Вы не набрали номер ");
        }
        public void insert_simcard()
        {
            if (SIMcard == 0)
            {
                SIMcard++;
                MessageBox.Show("Вы вставили симку ");
            }

            else
                MessageBox.Show("Симка уже вставлена ");

        }



    }
    public class SmartPhone : Mobile_phone
    {
        public int percentage_charge { get; set; }
        public int photos { get; set; }
        public SmartPhone() : base("", 0, 0)
        {
            this.percentage_charge = 0;
            this.photos = 0;
        }
        public SmartPhone(string number, int contacts, int simcard, int percentage_charge, int photos) : base(number, contacts, simcard)
        {
            this.percentage_charge = percentage_charge;
            this.photos = photos;
        }
        public void take_photo()
        {
            photos++;
            MessageBox.Show("Вы сделали снимок на телефон");
        }
        public void charge_phone()
        {
            if (percentage_charge < 100)
            {
                percentage_charge = 100;
                MessageBox.Show("Вы зарядили телефон");
            }

            else
                MessageBox.Show("iPhone заряжен");
        }
    }
}