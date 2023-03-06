using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polindrom_06._03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //FADI

            //string text = text_Eingabe.Text;
            //char[] reverse=text.ToCharArray();
            //Array.Reverse(reverse);
            //if (text==new string(reverse))
            //{
            //    textAusgabe.Text = "Ein Polidrom";
            //}
            //else
            //{
            //    textAusgabe.Text = "Kein Polidrom";
            //}

            //Alternative

            string _eingabe = text_Eingabe.Text;
            string reverse = string.Empty;

            for (int i = _eingabe.Length - 1; i >= 0; i--)
            {
                reverse += _eingabe[i];
            }

            if (_eingabe == reverse)
            {
                textAusgabe.Text = "Ein Polindrom";
            }
            else
            {
                textAusgabe.Text = "Kein Ploindrom";
            }

        }

        private void text_Eingabe_TextChanged(object sender, EventArgs e)
        {           
            
        }

        private void textAusgabe_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
