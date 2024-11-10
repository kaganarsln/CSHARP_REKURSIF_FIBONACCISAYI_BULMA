using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RekursifIleFibonacciBulma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int rekursiffibsayi ( int sayi) 
        {
            if (sayi< 1) 
            {
                return 0;
            }
            else if (sayi == 1) 
            {
                return 1;
            
            }
            else 
            {
                return rekursiffibsayi(sayi - 1) + rekursiffibsayi(sayi - 2);
            
            }
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            int sayi = Convert.ToInt32(textBox1.Text);

            for(int i = 0; i<= sayi; i++) 
            {
                listBox1.Items.Add(rekursiffibsayi(i));
            
            }

        }
    }
}
