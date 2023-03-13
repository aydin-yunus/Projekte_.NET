using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsForms_web_sites_13._03
{
    public partial class Form1 : Form
    {
        private string dateiName = null;
        private Regex tags = new Regex(@"(<[^>]+>)",
           RegexOptions.Multiline | RegexOptions.Compiled);
        public Form1()
        {
            InitializeComponent();
        }

        private void öffnenToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult result = ofdDateiÖffnen.ShowDialog();

            if (result == DialogResult.OK)
            {
                dateiName = ofdDateiÖffnen.FileName;
                textBox1.Text = File.ReadAllText(dateiName);
            }
            else
            {
                textBox1.Text = "Keine Aufwahl getroffen!";
            }
        }

        private void dateiToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void speichernToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (dateiName == null)
            {
                if (dateiName == null)
                {
                    DialogResult result = sfdDateiSpeichern.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        dateiName = sfdDateiSpeichern.FileName;
                    }
                }
                else
                {
                    File.WriteAllText(dateiName, textBox1.Text);
                }
            }
        }

        private void tagsZählenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String[] webSites = textBox1.Lines;

            Task.Factory.StartNew(() =>
            {

                WebClient client = new WebClient();

                foreach (String website in webSites)
                {
                    String textDerWebSite = client.DownloadString(website);
                    var len = CountTags(textDerWebSite);

                    Invoke(new Action<String>(UpdateText), String.Format("{0,-50} - {1,10} Tag(s){2}",
                         website, len, Environment.NewLine));


                }
            });
        }

        private int CountTags(string textDerWebSite)
        {
            return tags.Matches(textDerWebSite).Count;

        }

        private void UpdateText(String text)
        {
            textBox2.AppendText(text);
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox2.Text = String.Empty;
        }
    }
}
