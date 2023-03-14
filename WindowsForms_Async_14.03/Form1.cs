using DocumentFormat.OpenXml.Vml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Async_14._03
{
    public partial class Form1 : Form
    {
        private string wörterInDatei = null;
        public Form1()
        {
            InitializeComponent();
        }

        private async void öffnenToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {                
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                wörterInDatei=await sr.ReadToEndAsync();
                sr.Close();
                tbStatus.Text = $"{openFileDialog1.FileName} ";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void zählenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (wörterInDatei != null)
            {
                string häufigkeit = await Task<string>.Factory.StartNew(() =>
                {
                    return CountChars();
                });
                tbAusgabe.Text= häufigkeit;
            }
        }

        private string CountChars()
        {
            StringBuilder sb = new StringBuilder();
            Dictionary<char,int> chars= new Dictionary<char,int>();
            if (!string.IsNullOrEmpty(wörterInDatei)) 
            {
                foreach (char c in wörterInDatei)
                {
                    if (!char.IsLetter(c)) continue;
                    if (chars.ContainsKey(c))
                    {
                        chars[c]++;
                    }
                    else
                    {
                        chars.Add(c, 1);
                    }
                }
                foreach (var p in chars.OrderBy(x => x.Key))
                {
                    sb.Append(string.Format("{0} : {1}",p.Key,p.Value)+Environment.NewLine);
                }
            }
            return sb.ToString();
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
