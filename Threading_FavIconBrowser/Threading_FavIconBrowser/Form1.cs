using System.Net;

namespace Threading_FavIconBrowser
{
    public partial class Form1 : Form
    {
        private readonly List<string> domains = new List<string> {
                                                        "google.de",
                                                        "bing.com",
                                                        "heise.de",
                                                        "microsoft.com",
                                                        "facebook.com",
                                                        "twitter.com",
                                                        "amazon.de",
                                                        "spiegel.de",
                                                        "rheinwerk-verlag.de",
                                                        "reddit.com",
                                                        "youtube.com",
                                                        "de.wikipedia.org",
                                                        "startpage.com",
                                                        };

        private CancellationTokenSource cts;

        public Form1()
        {
            InitializeComponent();
            listBoxUrls.Items.AddRange(domains.ToArray());
        }

        private async void buttonDownload_Click(object sender, EventArgs e)
        {
            cts = new CancellationTokenSource();

            Cursor = Cursors.WaitCursor;

            buttonDownload.Enabled = false;

            foreach (string domain in listBoxUrls.Items)
            {
                try
                {
                    await AddAFaviconAsync(domain);

                    if (cts.Token.IsCancellationRequested)
                    {
                        return;
                    }
                }
                catch (Exception ex)
                {
                    richTextBoxMessages.Text += ex.Message + " " + domain + Environment.NewLine;
                }
            }

            Cursor = Cursors.Default;

            buttonDownload.Enabled = true;

        }

        private async Task AddAFaviconAsync(string domain)
        {
            WebClient webClient = new WebClient();

            byte[] imageBytes = await webClient.DownloadDataTaskAsync(new Uri("http://" + domain + "/favicon.ico"));

            if (cts.Token.IsCancellationRequested)
            {
                return;
            }

            CreatePictureBox(imageBytes);
        }

        private void CreatePictureBox(byte[] bytes)
        {
            PictureBox pictureBox = new PictureBox()
            {
                Width = 32,
                Height = 32
            };

            // Der Stream darf nicht geschlossen werden!
            MemoryStream ms = new MemoryStream(bytes);
            pictureBox.Image = Image.FromStream(ms);

            flowLayoutPanelIcons.Controls.Add(pictureBox);
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            cts.Cancel();

            Cursor = Cursors.Default;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            cts.Cancel();

            flowLayoutPanelIcons.Controls.Clear();
            richTextBoxMessages.Clear();

            Cursor = Cursors.Default;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}