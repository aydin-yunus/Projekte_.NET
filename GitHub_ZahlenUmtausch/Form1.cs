using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitHub_ZahlenUmtausch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int hunderts = 0, tens = 0, ones = 0, eingabe;
            string ausgabe = "";
            eingabe = Convert.ToInt32(textBox1.Text);

            if (eingabe <= 0 || eingabe >= 1000)
            {
                MessageBox.Show("Zwischen 0-1000 Bitte!!!");
            }
            if (eingabe > 99)
            {
                hunderts = eingabe / 100;
                if (eingabe - (hunderts * 100) == 0)
                {
                    goto ifEnde;
                }
                tens = (eingabe - (hunderts * 100)) / 10;
                ones = eingabe - ((hunderts * 100) + (tens * 10));
            }
            else if (eingabe > 9)
            {
                tens = eingabe / 10;
                ones = eingabe - ((tens * 10));
            }
            else
            {
                ones = eingabe;
            }
        ifEnde:
            if (hunderts > 0)
            {
                switch (hunderts)
                {
                    case 1:
                        ausgabe = "C";
                        break;
                    case 2:
                        ausgabe = "CC";
                        break;
                    case 3:
                        ausgabe = "CCC";
                        break;
                    case 4:
                        ausgabe = "CD";
                        break;
                    case 5:
                        ausgabe = "D";
                        break;
                    case 6:
                        ausgabe = "DC";
                        break;
                    case 7:
                        ausgabe = "DCC";
                        break;
                    case 8:
                        ausgabe = "DCC";
                        break;
                    case 9:
                        ausgabe = "CM";
                        break;
                }
            }
            if (tens > 0)
            {
                switch (tens)
                {
                    case 1:
                        ausgabe += "X";
                        break;
                    case 2:
                        ausgabe += "XX";
                        break;
                    case 3:
                        ausgabe += "XXX";
                        break;
                    case 4:
                        ausgabe += "XL";
                        break;
                    case 5:
                        ausgabe += "L";
                        break;
                    case 6:
                        ausgabe += "LX";
                        break;
                    case 7:
                        ausgabe += "LXX";
                        break;
                    case 8:
                        ausgabe += "LXXX";
                        break;
                    case 9:
                        ausgabe += "XC";
                        break;
                }
            }
            if (ones > 0)
            {
                switch (ones)
                {
                    case 1:
                        ausgabe += "I";
                        break;
                    case 2:
                        ausgabe += "II";
                        break;
                    case 3:
                        ausgabe += "III";
                        break;
                    case 4:
                        ausgabe += "IV";
                        break;
                    case 5:
                        ausgabe += "V";
                        break;
                    case 6:
                        ausgabe += "VI";
                        break;
                    case 7:
                        ausgabe += "VII";
                        break;
                    case 8:
                        ausgabe += "VIII";
                        break;
                    case 9:
                        ausgabe += "IX";
                        break;
                }
            }
            label1.Text=Convert.ToString(ausgabe);
        }
    }
}
