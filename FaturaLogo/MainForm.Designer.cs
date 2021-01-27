
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
            this.FaturayaLogo = new System.Windows.Forms.WebBrowser();
            this.openFileDialogFatura = new System.Windows.Forms.OpenFileDialog();
            this.btnLogoSec = new System.Windows.Forms.Button();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.işlemler = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.işlemler.SuspendLayout();
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
            // FaturayaLogo
            // 
            this.FaturayaLogo.Location = new System.Drawing.Point(203, 13);
            this.FaturayaLogo.MinimumSize = new System.Drawing.Size(20, 20);
            this.FaturayaLogo.Name = "FaturayaLogo";
            this.FaturayaLogo.Size = new System.Drawing.Size(1083, 576);
            this.FaturayaLogo.TabIndex = 1;
            // 
            // openFileDialogFatura
            // 
            this.openFileDialogFatura.FileName = "openFileDialog1";
            // 
            // btnLogoSec
            // 
            this.btnLogoSec.Location = new System.Drawing.Point(6, 58);
            this.btnLogoSec.Name = "btnLogoSec";
            this.btnLogoSec.Size = new System.Drawing.Size(158, 23);
            this.btnLogoSec.TabIndex = 2;
            this.btnLogoSec.Text = "Logo Seç";
            this.btnLogoSec.UseVisualStyleBackColor = true;
            this.btnLogoSec.Visible = false;
            this.btnLogoSec.Click += new System.EventHandler(this.btnLogoSec_Click);
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(64, 132);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 20);
            this.txtWidth.TabIndex = 3;
            this.txtWidth.Visible = false;
            this.txtWidth.TextChanged += new System.EventHandler(this.txtWidth_TextChanged);
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(64, 167);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 20);
            this.txtHeight.TabIndex = 3;
            this.txtHeight.Visible = false;
            this.txtHeight.TextChanged += new System.EventHandler(this.txtHeight_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Uzunluk";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Yükseklik";
            this.label2.Visible = false;
            // 
            // işlemler
            // 
            this.işlemler.Controls.Add(this.btnPrint);
            this.işlemler.Controls.Add(this.btnFaturaSec);
            this.işlemler.Controls.Add(this.label2);
            this.işlemler.Controls.Add(this.btnLogoSec);
            this.işlemler.Controls.Add(this.label1);
            this.işlemler.Controls.Add(this.txtWidth);
            this.işlemler.Controls.Add(this.txtHeight);
            this.işlemler.Location = new System.Drawing.Point(12, 13);
            this.işlemler.Name = "işlemler";
            this.işlemler.Size = new System.Drawing.Size(185, 199);
            this.işlemler.TabIndex = 6;
            this.işlemler.TabStop = false;
            this.işlemler.Text = "groupBox1";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(6, 97);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(158, 23);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Text = "Yazdır";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Visible = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 511);
            this.Controls.Add(this.işlemler);
            this.Controls.Add(this.FaturayaLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Kafkas oto lastik";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.işlemler.ResumeLayout(false);
            this.işlemler.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFaturaSec;
        private System.Windows.Forms.WebBrowser FaturayaLogo;
        private System.Windows.Forms.OpenFileDialog openFileDialogFatura;
        private System.Windows.Forms.Button btnLogoSec;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox işlemler;
        private System.Windows.Forms.Button btnPrint;
    }
}

