
namespace FaturaLogo
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnFaturaSec = new System.Windows.Forms.Button();
            this.FaturayaLogoBrowser = new System.Windows.Forms.WebBrowser();
            this.openFileDialogFatura = new System.Windows.Forms.OpenFileDialog();
            this.btnLogoSec = new System.Windows.Forms.Button();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpBox1 = new System.Windows.Forms.GroupBox();
            this.btnKaseSec = new System.Windows.Forms.Button();
            this.btnPdf = new System.Windows.Forms.Button();
            this.radioKase = new System.Windows.Forms.RadioButton();
            this.radioLogo = new System.Windows.Forms.RadioButton();
            this.pictureBoxKase = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.openFileDialogLogo = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogKase = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogPdf = new System.Windows.Forms.SaveFileDialog();
            this.btnKarekodKaldir = new System.Windows.Forms.Button();
            this.grpBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFaturaSec
            // 
            this.btnFaturaSec.Location = new System.Drawing.Point(6, 19);
            this.btnFaturaSec.Name = "btnFaturaSec";
            this.btnFaturaSec.Size = new System.Drawing.Size(158, 23);
            this.btnFaturaSec.TabIndex = 0;
            this.btnFaturaSec.Text = "Fatura Seç";
            this.btnFaturaSec.UseVisualStyleBackColor = true;
            this.btnFaturaSec.Click += new System.EventHandler(this.btnFaturaSec_Click);
            // 
            // FaturayaLogoBrowser
            // 
            this.FaturayaLogoBrowser.Location = new System.Drawing.Point(203, 13);
            this.FaturayaLogoBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.FaturayaLogoBrowser.Name = "FaturayaLogoBrowser";
            this.FaturayaLogoBrowser.Size = new System.Drawing.Size(1083, 684);
            this.FaturayaLogoBrowser.TabIndex = 1;
            // 
            // openFileDialogFatura
            // 
            this.openFileDialogFatura.FileName = "openFileDialogFatura";
            // 
            // btnLogoSec
            // 
            this.btnLogoSec.Location = new System.Drawing.Point(6, 55);
            this.btnLogoSec.Name = "btnLogoSec";
            this.btnLogoSec.Size = new System.Drawing.Size(158, 23);
            this.btnLogoSec.TabIndex = 2;
            this.btnLogoSec.Text = "Logo Seç";
            this.btnLogoSec.UseVisualStyleBackColor = true;
            this.btnLogoSec.Click += new System.EventHandler(this.btnLogoSec_Click);
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(64, 201);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 20);
            this.txtWidth.TabIndex = 3;
            this.txtWidth.Text = "150";
            this.txtWidth.TextChanged += new System.EventHandler(this.txtWidth_TextChanged);
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(64, 236);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 20);
            this.txtHeight.TabIndex = 3;
            this.txtHeight.Text = "150";
            this.txtHeight.TextChanged += new System.EventHandler(this.txtHeight_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Uzunluk";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Yükseklik";
            // 
            // grpBox1
            // 
            this.grpBox1.Controls.Add(this.btnKarekodKaldir);
            this.grpBox1.Controls.Add(this.btnKaseSec);
            this.grpBox1.Controls.Add(this.btnPdf);
            this.grpBox1.Controls.Add(this.radioKase);
            this.grpBox1.Controls.Add(this.radioLogo);
            this.grpBox1.Controls.Add(this.pictureBoxKase);
            this.grpBox1.Controls.Add(this.pictureBoxLogo);
            this.grpBox1.Controls.Add(this.btnPrint);
            this.grpBox1.Controls.Add(this.btnFaturaSec);
            this.grpBox1.Controls.Add(this.label2);
            this.grpBox1.Controls.Add(this.btnLogoSec);
            this.grpBox1.Controls.Add(this.label1);
            this.grpBox1.Controls.Add(this.txtWidth);
            this.grpBox1.Controls.Add(this.txtHeight);
            this.grpBox1.Location = new System.Drawing.Point(12, 13);
            this.grpBox1.Name = "grpBox1";
            this.grpBox1.Size = new System.Drawing.Size(185, 654);
            this.grpBox1.TabIndex = 6;
            this.grpBox1.TabStop = false;
            this.grpBox1.Text = "İşlemler";
            // 
            // btnKaseSec
            // 
            this.btnKaseSec.Location = new System.Drawing.Point(6, 92);
            this.btnKaseSec.Name = "btnKaseSec";
            this.btnKaseSec.Size = new System.Drawing.Size(158, 23);
            this.btnKaseSec.TabIndex = 15;
            this.btnKaseSec.Text = "Kaşe Seç";
            this.btnKaseSec.UseVisualStyleBackColor = true;
            this.btnKaseSec.Click += new System.EventHandler(this.btnKaseSec_Click);
            // 
            // btnPdf
            // 
            this.btnPdf.Location = new System.Drawing.Point(6, 273);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(158, 23);
            this.btnPdf.TabIndex = 13;
            this.btnPdf.Text = "pdf çıktı";
            this.btnPdf.UseVisualStyleBackColor = true;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // radioKase
            // 
            this.radioKase.AutoSize = true;
            this.radioKase.Location = new System.Drawing.Point(6, 368);
            this.radioKase.Name = "radioKase";
            this.radioKase.Size = new System.Drawing.Size(71, 17);
            this.radioKase.TabIndex = 12;
            this.radioKase.TabStop = true;
            this.radioKase.Text = "kaşe ekle";
            this.radioKase.UseVisualStyleBackColor = true;
            // 
            // radioLogo
            // 
            this.radioLogo.AutoSize = true;
            this.radioLogo.Location = new System.Drawing.Point(6, 344);
            this.radioLogo.Name = "radioLogo";
            this.radioLogo.Size = new System.Drawing.Size(68, 17);
            this.radioLogo.TabIndex = 11;
            this.radioLogo.TabStop = true;
            this.radioLogo.Text = "logo ekle";
            this.radioLogo.UseVisualStyleBackColor = true;
            // 
            // pictureBoxKase
            // 
            this.pictureBoxKase.Location = new System.Drawing.Point(6, 503);
            this.pictureBoxKase.Name = "pictureBoxKase";
            this.pictureBoxKase.Size = new System.Drawing.Size(158, 105);
            this.pictureBoxKase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxKase.TabIndex = 10;
            this.pictureBoxKase.TabStop = false;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Location = new System.Drawing.Point(6, 392);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(158, 105);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 7;
            this.pictureBoxLogo.TabStop = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(6, 312);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(158, 23);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Text = "Yazdır";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // openFileDialogLogo
            // 
            this.openFileDialogLogo.FileName = "openFileDialogLogo";
            // 
            // openFileDialogKase
            // 
            this.openFileDialogKase.FileName = "openFileDialogKase";
            // 
            // btnKarekodKaldir
            // 
            this.btnKarekodKaldir.Location = new System.Drawing.Point(6, 128);
            this.btnKarekodKaldir.Name = "btnKarekodKaldir";
            this.btnKarekodKaldir.Size = new System.Drawing.Size(158, 23);
            this.btnKarekodKaldir.TabIndex = 16;
            this.btnKarekodKaldir.Text = "Karekod Kaldır";
            this.btnKarekodKaldir.UseVisualStyleBackColor = true;
            this.btnKarekodKaldir.Click += new System.EventHandler(this.btnKarekodKaldir_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 709);
            this.Controls.Add(this.grpBox1);
            this.Controls.Add(this.FaturayaLogoBrowser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Kafkas oto lastik";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.grpBox1.ResumeLayout(false);
            this.grpBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFaturaSec;
        private System.Windows.Forms.WebBrowser FaturayaLogoBrowser;
        private System.Windows.Forms.OpenFileDialog openFileDialogFatura;
        private System.Windows.Forms.Button btnLogoSec;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpBox1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.OpenFileDialog openFileDialogLogo;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.RadioButton radioKase;
        private System.Windows.Forms.RadioButton radioLogo;
        private System.Windows.Forms.PictureBox pictureBoxKase;
        private System.Windows.Forms.OpenFileDialog openFileDialogKase;
        private System.Windows.Forms.Button btnKaseSec;
        private System.Windows.Forms.SaveFileDialog saveFileDialogPdf;
        private System.Windows.Forms.Button btnKarekodKaldir;
    }
}

