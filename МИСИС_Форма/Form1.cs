using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace МИСИС_Форма
{
    public partial class Form1 : Form
    {
        Thread th;
        public Form1()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string logins = "sergey";
            string passwords = "sergey";
            string login = "admin";
            string password = "admin";
            string logindekan = "dekan";
            string passwordekan = "dekan";
            if (textBox1.Text == login && textBox2.Text == password)
            {
                this.Close();
                th = new Thread(open);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            if (textBox1.Text == logins && textBox2.Text == passwords)
            {
                this.Close();
                th = new Thread(open1);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            if (textBox1.Text == logindekan && textBox2.Text == passwordekan)
            {
                this.Close();
                th = new Thread(open2);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }

            else
            {
                Form5 inr = new Form5();
                inr.Show();
            }
        }
        public void open(object obj)
        {
            Application.Run(new Form2());
        }
        public void open1(object obj)
        {
            Application.Run(new Form8());
        }
        public void open2(object obj)
        {
            Application.Run(new Form10());
        }
    }
}
