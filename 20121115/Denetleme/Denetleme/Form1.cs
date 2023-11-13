using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Denetleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            int sonuc;

            //Properties de Build içinde Advanced kısmında
            //check for... yazan yer işaretli değilse
            //kontrol etmediği int değişkenlerin değerlerini
            //kontrol etmek için aşağıdaki checked özelliği
            //kullanılır.

            checked
            {
                sonuc = sayi1 * sayi2;
            }

            label4.Text = sonuc.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            int sonuc;

            //Properties de Build içinde Advanced kısmında
            //check for... yazan yer işaretli ise
            //kontrol ettiği int değişkenlerin değerlerini
            //kontrol etmemesi için aşağıdaki unchecked özelliği
            //kullanılır.

            unchecked
            {
                sonuc = sayi1 * sayi2;
            }

            label4.Text = sonuc.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            throw new InvalidTimeZoneException("bu hata keyfi bir hatadır..");
        }
    }
}
