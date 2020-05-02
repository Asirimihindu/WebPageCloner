namespace WebPageCloner
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
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.buttonDownload = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGetLinks = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point(39, 62);
            this.textBoxURL.Multiline = true;
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(600, 74);
            this.textBoxURL.TabIndex = 0;
            // 
            // buttonDownload
            // 
            this.buttonDownload.Location = new System.Drawing.Point(39, 163);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(127, 42);
            this.buttonDownload.TabIndex = 1;
            this.buttonDownload.Text = "Download";
            this.buttonDownload.UseVisualStyleBackColor = true;
            this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "URL";
            // 
            // buttonGetLinks
            // 
            this.buttonGetLinks.Location = new System.Drawing.Point(214, 163);
            this.buttonGetLinks.Name = "buttonGetLinks";
            this.buttonGetLinks.Size = new System.Drawing.Size(104, 42);
            this.buttonGetLinks.TabIndex = 3;
            this.buttonGetLinks.Text = "Get Links";
            this.buttonGetLinks.UseVisualStyleBackColor = true;
            this.buttonGetLinks.Click += new System.EventHandler(this.buttonGetLinks_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(39, 227);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(706, 212);
            this.listBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(647, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Scraped Links";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(368, 163);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(104, 42);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonGetLinks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDownload);
            this.Controls.Add(this.textBoxURL);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Web Page Cloner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.Button buttonDownload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGetLinks;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonClear;
    }
}

