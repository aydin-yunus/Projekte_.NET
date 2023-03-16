using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Services___03___Warenkatalog_15._03.JSONFile;

namespace Services___03___Warenkatalog_15._03
{
    public partial class Form1 : Form
    {
        HttpClient webClient;
        string baseurl = "https://api.predic8.de/shop/products/";
        string baseurl_without_shop_products = "https://api.predic8.de";
        Dictionary<string, Productobject> product_List = new Dictionary<string, Productobject>();
        Dictionary<string, vendors> vendors_dic = new Dictionary<string, vendors>();
        Dictionary<string, Category> category_dic = new Dictionary<string, Category>();
        Rootobject rootobject;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webClient = new HttpClient();
            Fill_textlistAsync();
        }

        private async Task Fill_textlistAsync()
        {
            string result = await webClient.GetStringAsync(baseurl);
            rootobject = JsonConvert.DeserializeObject<Rootobject>(result);
            List<string> p = new List<string>();
            foreach (var item in rootobject.products)
            {
                p.Add(item.name);
                string result_pruduct = await webClient.GetStringAsync(baseurl_without_shop_products + item.product_url);
                Productobject P = JsonConvert.DeserializeObject<Productobject>(result_pruduct);
                string result_vender = await webClient.GetStringAsync(baseurl_without_shop_products + P.vendor_url);
                vendors v = JsonConvert.DeserializeObject<vendors>(result_vender);
                string result_Category = await webClient.GetStringAsync(baseurl_without_shop_products + P.category_url);
                Category c = JsonConvert.DeserializeObject<Category>(result_Category);
                product_List.Add(item.name, P);
                vendors_dic.Add(item.name, v);
                category_dic.Add(item.name, c);
                ;
            }
            listBox1.Items.AddRange(p.ToArray());
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedProductName = string.Empty;
            selectedProductName = ((ListBox)sender).SelectedItem.ToString();

            foreach (var item in product_List)
            {
                if (selectedProductName == item.Key)
                {
                    tbName.Text = item.Value.name;
                    tbPreis.Text = item.Value.price.ToString();
                    DrawImage(item.Value.photo_url);
                }
            }
            foreach (var item in vendors_dic)
            {
                if (selectedProductName == item.Key)
                {
                    tbHersteller.Text = item.Value.name;
                }
            }
            foreach (var item in category_dic)
            {
                tbCategory.Text = item.Value.name;
            }
        }

        private async void DrawImage(string photo_url)
        {
            try
            {
                WebClient webClientPhoto = new WebClient();
                byte[] image = await webClientPhoto.DownloadDataTaskAsync(baseurl_without_shop_products + photo_url);
                MemoryStream memoryStream = new MemoryStream(image);
                picBox.Image = Image.FromStream(memoryStream);
            }
            catch (Exception)
            {

                MessageBox.Show("Es gibt kein Picture");
            }

        }
    }
}
