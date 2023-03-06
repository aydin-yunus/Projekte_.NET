namespace Polindrom_06._03
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
            this.button1 = new System.Windows.Forms.Button();
            this.text_Eingabe = new System.Windows.Forms.TextBox();
            this.textAusgabe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(433, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Prüfen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // text_Eingabe
            // 
            this.text_Eingabe.Location = new System.Drawing.Point(422, 95);
            this.text_Eingabe.Name = "text_Eingabe";
            this.text_Eingabe.Size = new System.Drawing.Size(189, 20);
            this.text_Eingabe.TabIndex = 1;
            this.text_Eingabe.TextChanged += new System.EventHandler(this.text_Eingabe_TextChanged);
            // 
            // textAusgabe
            // 
            this.textAusgabe.Location = new System.Drawing.Point(422, 198);
            this.textAusgabe.Name = "textAusgabe";
            this.textAusgabe.Size = new System.Drawing.Size(189, 20);
            this.textAusgabe.TabIndex = 2;
            this.textAusgabe.TextChanged += new System.EventHandler(this.textAusgabe_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 469);
            this.Controls.Add(this.textAusgabe);
            this.Controls.Add(this.text_Eingabe);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox text_Eingabe;
        private System.Windows.Forms.TextBox textAusgabe;
    }
}

