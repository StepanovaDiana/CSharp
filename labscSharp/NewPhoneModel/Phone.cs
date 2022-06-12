using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public interface Phone
    {
        int number { get; set; }
        void call(int number_phone);
        void take_call();


    }
    public abstract class Mobile_phone : Phone
    {
        public int number { get; set; }
        public int contacts { get; set; }
        public int SIMcard { get; set; }

        public Mobile_phone(int number, int contacts, int simcard)
        {
            this.number = number;
            this.contacts = contacts;
            this.SIMcard = simcard;
        }

        public void call(int number_phone)
        {
            
         MessageBox.Show("Вы позвонили на номер " + number_phone);
           

        }
        public void take_call()
        {
            MessageBox.Show("Вы приняли звонок ");
        }
        public void add_contacts()
        {
             contacts++;
                MessageBox.Show("Вы добавили контакт ");
            
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
    public class Iphone : Mobile_phone
    {
        public int percentage_charge { get; set; }
        public int photos { get; set; }
        public Iphone():base(0,0,0)
        {
            this.percentage_charge = 0;
            this.photos = 0;
        }
        public Iphone(int number, int contacts, int simcard, int percentage_charge, int photos) : base(number, contacts, simcard)
        {
            this.percentage_charge = percentage_charge;
            this.photos = photos;
        }
        public void take_photo()
        {
            photos++;
            MessageBox.Show("Вы сделали снимок на iPhone");
        }
        public void charge_phone()
        {
            if (percentage_charge < 100)
            {
                percentage_charge = 100;
                MessageBox.Show("Вы зарядили iPhone");
            }

            else
                MessageBox.Show("iPhone заряжен");
        }
    }
    public class Samsung : Mobile_phone
    {
        public int percentage_charge { get; set; }
        public int photos { get; set; }
        public Samsung() : base(0, 0, 0)
        {
            this.percentage_charge = 0;
            this.photos = 0;
        }
        public Samsung(int number, int contacts, int simcard, int percentage_charge, int photos) : base(number, contacts, simcard)
        {
            this.percentage_charge = percentage_charge;
            this.photos = photos;
        }
        public void take_photo()
        {
            photos++;
            MessageBox.Show("Вы сделали снимок на Samsung ");
        }
        public void charge_phone()
        {
            if (percentage_charge < 100)
            {
                percentage_charge = 100;
                MessageBox.Show("Вы зарядили Samsung  ");
            }

            else
                MessageBox.Show("Samsung заряжен ");
        }
    }

    public class Nokia : Mobile_phone
    {
        public int percentage_charge { get; set; }
        public int photos { get; set; }
        public Nokia() : base(0, 0, 0)
        {
            this.percentage_charge = 0;
            this.photos = 0;
        }
        public Nokia(int number, int contacts, int simcard, int percentage_charge, int photos) : base(number, contacts, simcard)
        {
            this.percentage_charge = percentage_charge;
            this.photos = photos;
        }
        public void take_photo()
        {
            photos++;
            MessageBox.Show("Вы сделали снимок на Nokia ");
        }
        public void charge_phone()
        {
            if (percentage_charge < 100)
            {
                percentage_charge = 100;
                MessageBox.Show("Вы зарядили Nokia  ");
            }

            else
                MessageBox.Show("Nokia заряжен ");
        }
    }
}
