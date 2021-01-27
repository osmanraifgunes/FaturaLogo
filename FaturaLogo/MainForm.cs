using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
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
            if (File.Exists("previoulogo.txt"))
            {
                openFileDialogLogo.FileName = File.ReadAllText("previoulogo.txt");
                pictureBoxLogo.ImageLocation = File.ReadAllText("previoulogo.txt");
            }


            if (File.Exists("previoukase.txt"))
            {
                openFileDialogKase.FileName = File.ReadAllText("previoukase.txt");
                pictureBoxKase.ImageLocation = File.ReadAllText("previoukase.txt");
            }

            FaturayaLogoBrowser.DocumentText = "E-arşiv faturasını indirin. Zip veya html dosyasını seçin.";
        }
        private void htmlDocument_Click(object sender, HtmlElementEventArgs e)
        {
            if (radioKase.Checked)
            {
                HtmlElement kase = this.FaturayaLogoBrowser.Document.GetElementById("sirketKase");
                if (kase != null)
                {
                    kase.OuterHtml = "";
                }
                HtmlElement element = this.FaturayaLogoBrowser.Document.GetElementFromPoint(e.ClientMousePosition);
                HtmlElement userimage = FaturayaLogoBrowser.Document.CreateElement("img");
                userimage.SetAttribute("src", openFileDialogKase.FileName);
                userimage.Id = "sirketKase";
                userimage.Style = "width:150px; height:150px;";
                element.AppendChild(userimage);
            }
            else
            {
                HtmlElement logo = this.FaturayaLogoBrowser.Document.GetElementById("sirketLogo");
                if (logo != null)
                {
                    logo.OuterHtml = "";
                }
                HtmlElement element = this.FaturayaLogoBrowser.Document.GetElementFromPoint(e.ClientMousePosition);
                HtmlElement userimage = FaturayaLogoBrowser.Document.CreateElement("img");
                userimage.SetAttribute("src", openFileDialogLogo.FileName);
                userimage.Id = "sirketLogo";
                userimage.Style = "width:150px; height:150px;";
                element.AppendChild(userimage);
            }
           

        }

        private void btnFaturaSec_Click(object sender, EventArgs e)
        {

            openFileDialogFatura.Filter = "fatura dosyası |*.html;*.zip";
            if (openFileDialogFatura.ShowDialog() == DialogResult.OK)
            {
                if (Path.GetExtension(openFileDialogFatura.FileName) == ".html" || Path.GetExtension(openFileDialogFatura.FileName) == ".zip")
                {
                    if (Path.GetExtension(openFileDialogFatura.FileName) == ".zip")
                    {
                        string text = new string((new StreamReader(
                                        ZipFile.OpenRead(openFileDialogFatura.FileName)
                                        .Entries.Where(x => x.Name.Contains(".html"))
                                        .FirstOrDefault()
                                        .Open(), Encoding.UTF8)
                                        .ReadToEnd())
                                        .ToArray());
                        FaturayaLogoBrowser.DocumentText = text;
                    }
                    else
                    {
                        FaturayaLogoBrowser.DocumentText = File.ReadAllText(openFileDialogFatura.FileName);
                    }
                    btnLogoSec.Visible = true;
                    btnKaseSec.Visible = true;
                    this.FaturayaLogoBrowser.Document.MouseUp += new HtmlElementEventHandler(this.htmlDocument_Click);
                    MessageBox.Show("Logo Seçin ve fatura üzerinde logoyu eklemek istediğiniz yere tıklayın. Yer değiştirmek için de tıklayabilirsiniz.");
                }
                else
                {
                    MessageBox.Show("Sonu html veya zip ile biten dosya seçin");
                }
            }
        }
        public static readonly List<string> ImageExtensions = new List<string> { ".JPG", ".JPE", ".JPEG", ".BMP", ".GIF", ".PNG", ".JFIF" };

        private void btnLogoSec_Click(object sender, EventArgs e)
        {
            openFileDialogLogo.Filter = "fatura logo |*.jpg;*.jpeg;*.png;*.gif;*.bmp;*.jfif";
            if (openFileDialogLogo.ShowDialog() == DialogResult.OK)
            {

                if (ImageExtensions.Contains(Path.GetExtension(openFileDialogLogo.FileName).ToUpperInvariant()))
                {

                    label1.Visible = true;
                    label2.Visible = true;
                    txtWidth.Visible = true;
                    txtHeight.Visible = true;
                    btnPrint.Visible = true;
                    txtWidth.Text = "150";
                    txtHeight.Text = "150";
                    File.WriteAllText("previoulogo.txt", openFileDialogLogo.FileName);
                    pictureBoxLogo.ImageLocation = openFileDialogLogo.FileName;
                    radioLogo.Checked = true;
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
                MessageBox.Show("Sadece sayı girin.");
                txtWidth.Text = txtWidth.Text.Remove(txtWidth.Text.Length - 1);
            }
            if (radioKase.Checked)
            {
                HtmlElement logo = FaturayaLogoBrowser.Document.GetElementById("sirketLogo");
                if (logo != null)
                {
                    logo.Style = "width:" + txtWidth.Text + "px;";
                }
            }
            else
            {
                HtmlElement logo = FaturayaLogoBrowser.Document.GetElementById("sirketKase");
                if (logo != null)
                {
                    logo.Style = "width:" + txtWidth.Text + "px;";
                }
            }
        }

        private void txtHeight_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtHeight.Text, "[^0-9]"))
            {
                MessageBox.Show("Sadece sayı girin.");
                txtHeight.Text = txtHeight.Text.Remove(txtHeight.Text.Length - 1);
            }
            if (radioKase.Checked)
            {
                HtmlElement logo = FaturayaLogoBrowser.Document.GetElementById("sirketLogo");
                if (logo != null)
                {
                    logo.Style = "heigt:" + txtHeight.Text + "px;";
                }
            }
            else
            {
                HtmlElement logo = FaturayaLogoBrowser.Document.GetElementById("sirketKase");
                if (logo != null)
                {
                    logo.Style = "heigt:" + txtHeight.Text + "px;";
                }
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            FaturayaLogoBrowser.Width = Convert.ToInt32(this.Width * 0.80);
            grpBox1.Width = Convert.ToInt32(this.Width * 0.15);
            FaturayaLogoBrowser.Left = grpBox1.Right + 10;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            FaturayaLogoBrowser.ShowPrintDialog();
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yakında eklenecek");
        }

        private void btnKaseSec_Click(object sender, EventArgs e)
        {
            openFileDialogKase.Filter = "fatura kaşe |*.jpg;*.jpeg;*.png;*.gif;*.bmp;*.jfif";
            if (openFileDialogKase.ShowDialog() == DialogResult.OK)
            {

                if (ImageExtensions.Contains(Path.GetExtension(openFileDialogKase.FileName).ToUpperInvariant()))
                {
                    label1.Visible = true;
                    label2.Visible = true;
                    txtWidth.Visible = true;
                    txtHeight.Visible = true;
                    btnPrint.Visible = true;
                    txtWidth.Text = "150";
                    txtHeight.Text = "150";
                    File.WriteAllText("previoukase.txt", openFileDialogKase.FileName);
                    pictureBoxKase.ImageLocation = openFileDialogKase.FileName;
                    radioKase.Checked = true;

                }
                else
                {
                    MessageBox.Show("Resim dosyası seçin");
                }
            }
        }
    }
}
;