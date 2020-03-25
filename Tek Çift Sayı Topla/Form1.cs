using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tek_Çift_Sayı_Topla
{
    public partial class Form1 : Form
    {
        #region Değişkenler
        int a, b, toplam = 0;
       
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);

            if (comboBox1.Text=="Çiftler")
            {
                toplam = 0;
                if (a%2!=0)
                {
                    label5.Text = a + " İle " + b + " arasındaki çift sayılar toplamı"; 
                    a++;
                    for (int i = a; i < b; i = i + 2)
                    {
                        toplam += i;
                    }
                }

                else
                {
                    for (int i = a+2; i < b; i = i + 2)
                    {
                        toplam += i;
                    }
                }

                
            }

            else
            {
                label5.Text = a + " İle " + b + " arasındaki tek sayılar toplamı"; 
                toplam = 0;
                if (a % 2 == 0)
                {
                    a++;
                    for (int i = a; i < b; i = i + 2)
                    {
                        toplam += i;
                    }
                }

                else
                {
                    for (int i = a + 2; i < b; i = i + 2)
                    {
                        toplam += i;
                    }
                }

                
            }

            label4.Text = toplam.ToString();
        }
    }
}
