namespace Threading_FavIconBrowser
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxUrls = new ListBox();
            buttonDownload = new Button();
            buttonStop = new Button();
            buttonClear = new Button();
            groupBox1 = new GroupBox();
            flowLayoutPanelIcons = new FlowLayoutPanel();
            richTextBoxMessages = new RichTextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // listBoxUrls
            // 
            listBoxUrls.FormattingEnabled = true;
            listBoxUrls.ItemHeight = 15;
            listBoxUrls.Location = new Point(18, 12);
            listBoxUrls.Name = "listBoxUrls";
            listBoxUrls.Size = new Size(120, 154);
            listBoxUrls.TabIndex = 0;
            // 
            // buttonDownload
            // 
            buttonDownload.Location = new Point(138, 12);
            buttonDownload.Name = "buttonDownload";
            buttonDownload.Size = new Size(117, 23);
            buttonDownload.TabIndex = 1;
            buttonDownload.Text = "Download Icons";
            buttonDownload.UseVisualStyleBackColor = true;
            buttonDownload.Click += buttonDownload_Click;
            // 
            // buttonStop
            // 
            buttonStop.Location = new Point(138, 41);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new Size(117, 23);
            buttonStop.TabIndex = 2;
            buttonStop.Text = "Stop Downloads";
            buttonStop.UseVisualStyleBackColor = true;
            buttonStop.Click += buttonStop_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(138, 143);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(117, 23);
            buttonClear.TabIndex = 3;
            buttonClear.Text = "Clear Icons";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(flowLayoutPanelIcons);
            groupBox1.Location = new Point(12, 172);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(243, 226);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Icons";
            // 
            // flowLayoutPanelIcons
            // 
            flowLayoutPanelIcons.Location = new Point(6, 22);
            flowLayoutPanelIcons.Name = "flowLayoutPanelIcons";
            flowLayoutPanelIcons.Size = new Size(231, 198);
            flowLayoutPanelIcons.TabIndex = 0;
            // 
            // richTextBoxMessages
            // 
            richTextBoxMessages.Location = new Point(15, 405);
            richTextBoxMessages.Name = "richTextBoxMessages";
            richTextBoxMessages.ReadOnly = true;
            richTextBoxMessages.Size = new Size(240, 149);
            richTextBoxMessages.TabIndex = 5;
            richTextBoxMessages.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(268, 566);
            Controls.Add(richTextBoxMessages);
            Controls.Add(groupBox1);
            Controls.Add(buttonClear);
            Controls.Add(buttonStop);
            Controls.Add(buttonDownload);
            Controls.Add(listBoxUrls);
            Name = "Form1";
            Text = "FavIcon Browser";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxUrls;
        private Button buttonDownload;
        private Button buttonStop;
        private Button buttonClear;
        private GroupBox groupBox1;
        private FlowLayoutPanel flowLayoutPanelIcons;
        private RichTextBox richTextBoxMessages;
    }
}