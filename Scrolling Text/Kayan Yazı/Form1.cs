using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kayan_Yazı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = label1.Text.Substring(1) + label1.Text.Substring(0, 1);
            //Hoş geldiniz...
            //0123456789........
            //oş geldiniz...H
            //0123456789........
            //ş geldiniz...Ho
            // geldiniz...Hoş
            //geldiniz...Hoş 
            //eldiniz...Hoş g
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            timer1.Stop();
            timer2.Stop();
            frm2.ShowDialog();
            //frm2.Show();
            this.Close();//formu bellekten sildiği için proje kapanır.
            //this.Hide();//formu gizler, ancak hala bellektedir, kapatmaz.
        }
    }
}
