using OpenHtmlToPdf;
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
        StyleGenerator sg = new StyleGenerator();
        HtmlElement elem = null;
        string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\faturalogo\\";
        public MainForm()
        {
            InitializeComponent();
            if (!Directory.Exists(appDataPath))
            {
                Directory.CreateDirectory(appDataPath);
            }
            if (File.Exists(appDataPath + "previoulogo.txt"))
            {
                openFileDialogLogo.FileName = File.ReadAllText(appDataPath + "previoulogo.txt");
                pictureBoxLogo.ImageLocation = File.ReadAllText(appDataPath + "previoulogo.txt");
            }


            if (File.Exists(appDataPath + "previoukase.txt"))
            {
                openFileDialogKase.FileName = File.ReadAllText(appDataPath + "previoukase.txt");
                pictureBoxKase.ImageLocation = File.ReadAllText(appDataPath + "previoukase.txt");
            }

            FaturayaLogoBrowser.DocumentText = "E-arşiv faturasını indirin. Zip veya html dosyasını seçin.";
        }
        private void htmlDocument_Click(object sender, HtmlElementEventArgs e)
        {
            HtmlElement userimage = FaturayaLogoBrowser.Document.CreateElement("img");
            HtmlElement element = this.FaturayaLogoBrowser.Document.GetElementFromPoint(e.ClientMousePosition);
            if (radioKase.Checked)
            {
                HtmlElement kase = this.FaturayaLogoBrowser.Document.GetElementById("sirketKase");
                if (kase != null)
                {
                    kase.OuterHtml = "";
                }
                userimage.SetAttribute("src", openFileDialogKase.FileName);
                userimage.Id = "sirketKase";
            }
            else
            {
                HtmlElement logo = this.FaturayaLogoBrowser.Document.GetElementById("sirketLogo");
                if (logo != null)
                {
                    logo.OuterHtml = "";
                }
                userimage.SetAttribute("src", openFileDialogLogo.FileName);
                userimage.Id = "sirketLogo";
            }

            userimage.Style = "width:150px; height:150px;";
            element.AppendChild(userimage);

        }
        void Document_MouseOver(object sender, HtmlElementEventArgs e)
        {
            elem = FaturayaLogoBrowser.Document.GetElementFromPoint(e.MousePosition);

            sg.ParseStyleString(elem.Style);
            sg.SetStyle("background-color", "#dcdcdc");
            elem.Style = sg.GetStyleString();
        }

        void Document_MouseLeave(object sender, HtmlElementEventArgs e)
        {
            if (elem != null)
            {
                sg.RemoveStyle("background-color");
                elem.Style = sg.GetStyleString();
                // Reset, since we may mouse over a new DIV element next time.
                sg.Clear();
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
                        if (ZipFile.OpenRead(openFileDialogFatura.FileName)
                                        .Entries.Where(x => x.Name.Contains(".html"))
                                        .FirstOrDefault() == null)
                        {
                            MessageBox.Show("Dosya içerisinde html fatura yok.");
                            return;
                        }
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
                    this.FaturayaLogoBrowser.Document.MouseUp += new HtmlElementEventHandler(this.htmlDocument_Click);
                    FaturayaLogoBrowser.Document.MouseOver += new HtmlElementEventHandler(Document_MouseOver);
                    FaturayaLogoBrowser.Document.MouseLeave += new HtmlElementEventHandler(Document_MouseLeave);
                    MessageBox.Show("Logo Seçin ve fatura üzerinde logoyu eklemek istediğiniz yere tıklayın. Yer değiştirmek için de tıklayabilirsiniz.");
                    radioLogo.Checked = true;
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

                    txtWidth.Text = "150";
                    txtHeight.Text = "150";
                    File.WriteAllText(appDataPath + "previoulogo.txt", openFileDialogLogo.FileName);
                    pictureBoxLogo.ImageLocation = openFileDialogLogo.FileName;
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
            if (radioLogo.Checked)
            {
                HtmlElement logo = FaturayaLogoBrowser.Document.GetElementById("sirketLogo");
                if (logo != null)
                {
                    sg.ParseStyleString(logo.Style);
                    sg.SetStyle("width", txtWidth.Text + "px;");
                    logo.Style = sg.GetStyleString();
                }
            }
            else
            {
                HtmlElement kase = FaturayaLogoBrowser.Document.GetElementById("sirketKase");
                if (kase != null)
                {
                    sg.ParseStyleString(kase.Style);
                    sg.SetStyle("width", txtWidth.Text + "px;");
                    kase.Style = sg.GetStyleString();
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
            if (radioLogo.Checked)
            {
                HtmlElement logo = FaturayaLogoBrowser.Document.GetElementById("sirketLogo");
                if (logo != null)
                {
                    sg.ParseStyleString(logo.Style);
                    sg.SetStyle("height", txtHeight.Text + "px;");
                    logo.Style = sg.GetStyleString();
                }
            }
            else
            {
                HtmlElement kase = FaturayaLogoBrowser.Document.GetElementById("sirketKase");
                if (kase != null)
                {
                    sg.ParseStyleString(kase.Style);
                    sg.SetStyle("height", txtHeight.Text + "px;");
                    kase.Style = sg.GetStyleString();
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
            var pdf = Pdf.From(FaturayaLogoBrowser.DocumentText).Content();
            saveFileDialogPdf.DefaultExt = "pdf";
            saveFileDialogPdf.CheckPathExists = true;
            saveFileDialogPdf.Filter = "pdf (*.pdf)|*.pdf|All files (*.*)|*.*";
            saveFileDialogPdf.FileName = "fatura" + DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day + "-" + DateTime.Now.Hour + "-" + DateTime.Now.Minute;
            if (saveFileDialogPdf.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllBytes(saveFileDialogPdf.FileName, pdf);
            }

        }

        private void btnKaseSec_Click(object sender, EventArgs e)
        {
            openFileDialogKase.Filter = "fatura kaşe |*.jpg;*.jpeg;*.png;*.gif;*.bmp;*.jfif";
            if (openFileDialogKase.ShowDialog() == DialogResult.OK)
            {

                if (ImageExtensions.Contains(Path.GetExtension(openFileDialogKase.FileName).ToUpperInvariant()))
                {
                    File.WriteAllText(appDataPath + "previoukase.txt", openFileDialogKase.FileName);
                    pictureBoxKase.ImageLocation = openFileDialogKase.FileName;
                    radioKase.Checked = true;

                }
                else
                {
                    MessageBox.Show("Resim dosyası seçin");
                }
            }
        }

        private void btnKarekodKaldir_Click(object sender, EventArgs e)
        {
            HtmlElement qc = this.FaturayaLogoBrowser.Document.GetElementById("qrcode");
            if (qc != null)
            {
                qc.InnerHtml = "";
            }
        }
    }
}
;