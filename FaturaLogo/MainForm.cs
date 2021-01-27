using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaturaLogo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void htmlDocument_Click(object sender, HtmlElementEventArgs e)
        {
            HtmlElement element = this.FaturayaLogo.Document.GetElementFromPoint(e.ClientMousePosition);
            element.Id = "sirketLogoParent";
            element.Style += "background-color:#efefef;";
            this.FaturayaLogo.Document.MouseUp -= htmlDocument_Click;
            btnLogoSec.Visible = true;
        }

        private void btnFaturaSec_Click(object sender, EventArgs e)
        {

            openFileDialogFatura.Filter = "fatura dosyası |*.html";
            if (openFileDialogFatura.ShowDialog() == DialogResult.OK)
            {
                if (Path.GetExtension(openFileDialogFatura.FileName) == ".html")
                {
                    FaturayaLogo.DocumentText = File.ReadAllText(openFileDialogFatura.FileName);
                    HtmlDocument document = this.FaturayaLogo.Document;
                    document.MouseUp += new HtmlElementEventHandler(this.htmlDocument_Click);
                    MessageBox.Show("Fatura üzerinde logonun eklenecği yere tıklayın. Arka planı gri olacak. Yanlış tıklarsanız tekrar fatura dosyası seçin.");
                }
                else
                {
                    MessageBox.Show("Sonu html ile biten dosya seçin");
                }
            }
        }
        public static readonly List<string> ImageExtensions = new List<string> { ".JPG", ".JPE", ".JPEG", ".BMP", ".GIF", ".PNG", ".JFIF" };

        private void btnLogoSec_Click(object sender, EventArgs e)
        {
            openFileDialogFatura.Filter = "fatura logo |*.jpg;*.jpeg;*.png;*.gif;*.bmp;*.jfif";
            if (openFileDialogFatura.ShowDialog() == DialogResult.OK)
            {

                if (ImageExtensions.Contains(Path.GetExtension(openFileDialogFatura.FileName).ToUpperInvariant()))
                {
                    HtmlElement userimage = FaturayaLogo.Document.CreateElement("img");
                    userimage.SetAttribute("src", openFileDialogFatura.FileName);
                    userimage.Id = "sirketLogo";
                    userimage.Style = "width:150px;";
                    HtmlElement element = FaturayaLogo.Document.GetElementById("sirketLogoParent");
                    element.AppendChild(userimage);
                    element.Style = element.Style.Replace("BACKGROUND-COLOR: #efefef", "");

                    label1.Visible = true;
                    label2.Visible = true;
                    txtWidth.Visible = true;
                    txtHeight.Visible = true;
                    btnPrint.Visible = true;
                    txtWidth.Text = "150";
                    txtWidth.Text= "150";


                }
                else
                {
                    MessageBox.Show("Resim dosyası seçin");
                }
            }
        }

        private void txtWidth_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtWidth.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtWidth.Text = txtWidth.Text.Remove(txtWidth.Text.Length - 1);
            }
            FaturayaLogo.Document.GetElementById("sirketLogo").Style = "width:" + txtWidth.Text + "px;";
        }

        private void txtHeight_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtHeight.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtHeight.Text = txtHeight.Text.Remove(txtHeight.Text.Length - 1);
            }
            FaturayaLogo.Document.GetElementById("sirketLogo").Style = "width:" + txtHeight.Text + "px;";
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            FaturayaLogo.Width = Convert.ToInt32(this.Width * 0.80);
            işlemler.Width = Convert.ToInt32(this.Width * 0.15);
            FaturayaLogo.Left = işlemler.Right + 10;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            FaturayaLogo.ShowPrintDialog();
        }
    }
}
;