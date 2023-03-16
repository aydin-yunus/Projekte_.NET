namespace Services___03___Warenkatalog_15._03
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPreis = new System.Windows.Forms.TextBox();
            this.tbCategory = new System.Windows.Forms.TextBox();
            this.tbHersteller = new System.Windows.Forms.TextBox();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picBox);
            this.groupBox1.Controls.Add(this.tbHersteller);
            this.groupBox1.Controls.Add(this.tbCategory);
            this.groupBox1.Controls.Add(this.tbPreis);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(180, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(608, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Preis:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kategorie:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hersteller:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(52, 20);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 4;
            // 
            // tbPreis
            // 
            this.tbPreis.Location = new System.Drawing.Point(52, 47);
            this.tbPreis.Name = "tbPreis";
            this.tbPreis.Size = new System.Drawing.Size(100, 20);
            this.tbPreis.TabIndex = 5;
            // 
            // tbCategory
            // 
            this.tbCategory.Location = new System.Drawing.Point(229, 20);
            this.tbCategory.Name = "tbCategory";
            this.tbCategory.Size = new System.Drawing.Size(149, 20);
            this.tbCategory.TabIndex = 6;
            // 
            // tbHersteller
            // 
            this.tbHersteller.Location = new System.Drawing.Point(229, 47);
            this.tbHersteller.Name = "tbHersteller";
            this.tbHersteller.Size = new System.Drawing.Size(149, 20);
            this.tbHersteller.TabIndex = 7;
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(10, 73);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(592, 347);
            this.picBox.TabIndex = 8;
            this.picBox.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(169, 420);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbHersteller;
        private System.Windows.Forms.TextBox tbCategory;
        private System.Windows.Forms.TextBox tbPreis;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.ListBox listBox1;
    }
}

