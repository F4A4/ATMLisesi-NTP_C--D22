using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int OrtalamaBul(TextBox sinav1, TextBox sinav2, TextBox sinav3, TextBox sozlu1, TextBox sozlu2)
        {
            int ortMat = 0;

            try
            {
                int snv1 = int.Parse(sinav1.Text);
                int snv2 = int.Parse(sinav2.Text);
                int snv3 = int.Parse(sinav3.Text);
                int soz1 = int.Parse(sozlu1.Text);
                int soz2 = int.Parse(sozlu2.Text);

                if ((snv1 <= 100 && snv1 >= 0) && (snv2 <= 100 && snv2 >= 0) && (snv3 <= 100 && snv3 >= 0) && (soz1 <= 100 && soz1 >= 0) && (soz2 <= 100 && soz2 >= 0))
                {
                    ortMat = (snv1 + snv2 + snv3 + soz1 + soz2) / 5;
                }
                else
                {
                    MessageBox.Show("notları 0-100 aralığında giriniz..");
                }
            }
            catch(ArgumentNullException HATA4)
            {
                MessageBox.Show("Değer null(boş) olamaz...\n"+ HATA4.Message);
            }
            catch(FormatException HATA3)
            {
                MessageBox.Show("Giriş dizesi doğru biçimde değildir...\n"+ HATA3.Message);
            }
            catch(OverflowException HATA2)
            {
                MessageBox.Show("Girilen değeri bir int32 için çok büyük ya da çok küçüktür...\n"+ HATA2.Message);
            }
            catch (Exception HATA1)
            {
                MessageBox.Show("Hatalı giriş... TEKRAR DENEYİNİZ...\n"+ HATA1.Message);
            }

            return ortMat;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            textBox6.Text = OrtalamaBul(textBox1, textBox2, textBox3, textBox4, textBox5).ToString();
            button1.ForeColor = Color.DarkCyan;
           

        }

        //----------------------------------------------------------------------------------------------------

        private void button2_Click(object sender, EventArgs e)
        {
            textBox12.Text = OrtalamaBul(textBox7, textBox8, textBox9, textBox10, textBox11).ToString();
            button2.ForeColor = Color.DarkGreen;
        }

        //----------------------------------------------------------------------------------------------------

       
        private void button3_Click(object sender, EventArgs e)
        {
            textBox19.Text = OrtalamaBul(textBox24, textBox23, textBox22, textBox21, textBox20).ToString();
            button3.ForeColor = Color.DarkOrange;
        }

        //----------------------------------------------------------------------------------------------------

       
        
         private void button4_Click(object sender, EventArgs e)
        {
            textBox13.Text = OrtalamaBul(textBox18, textBox17, textBox16, textBox15, textBox14).ToString();
            button4.ForeColor = Color.DarkViolet;
        }

         //----------------------------------------------------------------------------------------------------

        private void button5_Click(object sender, EventArgs e)
        {
           
            try
            {
                int not1 = int.Parse(textBox6.Text);
                int not2 = int.Parse(textBox12.Text);
                int not3 = int.Parse(textBox19.Text);
                int not4 = int.Parse(textBox13.Text);

                textBox25.Text = ((not1 + not2 + not3 + not4) / 4).ToString();
                button5.ForeColor = Color.Fuchsia;
               
                int sayi = Int32.Parse(textBox25.Text);

                if (sayi > 0 && sayi < 25)
                {
                    textBox25.Text = sayi + "(0)";
                }
                if (sayi > 25 && sayi < 45)
                {
                    textBox25.Text = sayi + "(1)";
                }
                if (sayi > 45 && sayi < 55)
                {
                    textBox25.Text = sayi + "(2)";
                }
                if (sayi > 55 && sayi < 70)
                {
                    textBox25.Text = sayi + "(3)";
                }
                if (sayi > 70 && sayi < 85)
                {
                    textBox25.Text = sayi + "(4)";
                }
                if (sayi > 85 && sayi < 100)
                {
                    textBox25.Text = sayi + "(5)";
                }

            }
            catch (Exception)
            {

                MessageBox.Show("BEN ORTALAMAYA BAĞLIYIM ONU TAMAMLA ÖYLE");
            }
            finally
            {
                MessageBox.Show("----GÜLE GÜLE----");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        


    }
}

