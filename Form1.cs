using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebPageCloner
{
    public partial class Form1 : Form
    {   
        public Form1()
        {
            //this is the constructor 
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to Web Page Cloner App!");

        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {
            string filePath = string.Empty;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "HTML files (*.html)|*.html";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = saveFileDialog1.FileName;
            }

            string URL = textBoxURL.Text;
            HtmlWeb hw = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc = hw.Load(URL);

            using (System.IO.StreamWriter filewrite = new System.IO.StreamWriter(filePath))
            {
                filewrite.Write(doc.ParsedText); 
            }

            MessageBox.Show("Page downloaded! Please check!");
            textBoxURL.Text = "";


        }

        private void buttonGetLinks_Click(object sender, EventArgs e)
        {
            string URL = textBoxURL.Text;
            HtmlWeb hw = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc = hw.Load(URL);

            foreach (HtmlNode link in doc.DocumentNode.SelectNodes("//a"))
            {
                listBox1.Items.Add(link.GetAttributeValue("href",""));
            }

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxURL.Text="";
            listBox1.Items.Clear();

        }
    }
}
