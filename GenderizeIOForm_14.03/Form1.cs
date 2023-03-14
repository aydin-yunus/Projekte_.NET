using GenderizeIOForm.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenderizeIOForm_14._03
{
    public partial class GenderizeIOMainForm : Form
    {
        private Dictionary<string, GIOResponse> db;
        private string requstBaseUri;
        private string dbFileName;
        HttpClient client;
        public GenderizeIOMainForm()
        {
            InitializeComponent();
            db = new Dictionary<string, GIOResponse>();
            requstBaseUri = "http://api.genderize.io?name=";
            dbFileName = "";
            client = new HttpClient();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void btSearch_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbNameInput.Text))
            {
                String name = tbNameInput.Text.ToLower();
                bool local = true;
                if (!db.ContainsKey(name))
                {
                    string result = await client.GetStringAsync(requstBaseUri + tbNameInput.Text);
                    var obj = JsonConvert.DeserializeObject<GIOResponse>(result);
                    db.Add(name, obj);
                    local = false;
                }
                ShowResult(db[name], local);
            }
            else
            {
                MessageBox.Show("Suchbegriff fehlt!", "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ShowResult(GIOResponse gIOResponse, bool local = true)
        {
            tbOutput.Text = gIOResponse.ToString() + (local ? " (local)" : " (web)");
        }

        private void speichernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(dbFileName))
            {
                SaveFileDialog sfd = new SaveFileDialog();
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    dbFileName = sfd.FileName;
                }
            }
            if (!String.IsNullOrEmpty(dbFileName))
            {
                SaveData(dbFileName);
            }
            else
            {
                MessageBox.Show("Noch kein Dateiname festgelegt!", "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private async void SaveData(string dbFileName)
        {
            var formatting = new JsonSerializerSettings() { Formatting = Formatting.Indented };
            var data = JsonConvert.SerializeObject(db, formatting);
            using (var sw = new StreamWriter(dbFileName))
            {
                await sw.WriteLineAsync(data);
            }
        }

        private void öffnenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                dbFileName = ofd.FileName;
                LoadData(dbFileName);
            }
        }
        private async void LoadData(string dbFileName)
        {
            using (var sr = new StreamReader(dbFileName))
            {
                string file = await sr.ReadToEndAsync();
                db = JsonConvert.DeserializeObject<Dictionary<string, GIOResponse>>(file);
            }
        }

        private void speichernUnterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                dbFileName = sfd.FileName;
                SaveData(dbFileName);
            }
        }

        private void lokaleDBToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MessageBox.Show($"Unsere lokale DB hat {db.Count} Einträge.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
