namespace qr_code_generatort
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_barcode = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.Qr = new System.Windows.Forms.Label();
            this.txtQr = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.isLogo = new System.Windows.Forms.CheckBox();
            this.rdQrCode = new System.Windows.Forms.RadioButton();
            this.rdBarcode = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_barcode
            // 
            this.btn_barcode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_barcode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_barcode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_barcode.ForeColor = System.Drawing.Color.Gold;
            this.btn_barcode.Location = new System.Drawing.Point(371, 372);
            this.btn_barcode.Name = "btn_barcode";
            this.btn_barcode.Size = new System.Drawing.Size(122, 40);
            this.btn_barcode.TabIndex = 0;
            this.btn_barcode.Text = "Generate";
            this.btn_barcode.UseVisualStyleBackColor = true;
            this.btn_barcode.Click += new System.EventHandler(this.btn_barcode_Click_1);
            // 
            // btn_Save
            // 
            this.btn_Save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.ForeColor = System.Drawing.Color.Gold;
            this.btn_Save.Location = new System.Drawing.Point(502, 372);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(122, 40);
            this.btn_Save.TabIndex = 0;
            this.btn_Save.Text = "&Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // Qr
            // 
            this.Qr.AutoSize = true;
            this.Qr.ForeColor = System.Drawing.Color.Gold;
            this.Qr.Location = new System.Drawing.Point(368, 208);
            this.Qr.Name = "Qr";
            this.Qr.Size = new System.Drawing.Size(93, 13);
            this.Qr.TabIndex = 1;
            this.Qr.Text = "Enter Code Here *";
            // 
            // txtQr
            // 
            this.txtQr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQr.Location = new System.Drawing.Point(371, 239);
            this.txtQr.Name = "txtQr";
            this.txtQr.Size = new System.Drawing.Size(253, 26);
            this.txtQr.TabIndex = 3;
            this.txtQr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQr_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 94);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::qr_code_generatort.Properties.Resources.barcode_clipart_logo_8;
            this.pictureBox2.Location = new System.Drawing.Point(12, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Barcode and QR Code Generator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(369, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "This sotware generate a barcode, QR Code and can be save as a image file.";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::qr_code_generatort.Properties.Resources.websiteQRCode_noFrame;
            this.pictureBox3.Location = new System.Drawing.Point(563, 24);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(82, 49);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(20, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 288);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // isLogo
            // 
            this.isLogo.AutoSize = true;
            this.isLogo.ForeColor = System.Drawing.Color.Gold;
            this.isLogo.Location = new System.Drawing.Point(371, 325);
            this.isLogo.Name = "isLogo";
            this.isLogo.Size = new System.Drawing.Size(68, 17);
            this.isLogo.TabIndex = 5;
            this.isLogo.Text = "with logo";
            this.isLogo.UseVisualStyleBackColor = true;
            // 
            // rdQrCode
            // 
            this.rdQrCode.AutoSize = true;
            this.rdQrCode.ForeColor = System.Drawing.Color.Gold;
            this.rdQrCode.Location = new System.Drawing.Point(371, 289);
            this.rdQrCode.Name = "rdQrCode";
            this.rdQrCode.Size = new System.Drawing.Size(69, 17);
            this.rdQrCode.TabIndex = 6;
            this.rdQrCode.TabStop = true;
            this.rdQrCode.Text = "QR Code";
            this.rdQrCode.UseVisualStyleBackColor = true;
            // 
            // rdBarcode
            // 
            this.rdBarcode.AutoSize = true;
            this.rdBarcode.ForeColor = System.Drawing.Color.Gold;
            this.rdBarcode.Location = new System.Drawing.Point(462, 289);
            this.rdBarcode.Name = "rdBarcode";
            this.rdBarcode.Size = new System.Drawing.Size(69, 17);
            this.rdBarcode.TabIndex = 6;
            this.rdBarcode.TabStop = true;
            this.rdBarcode.Text = "Bar Code";
            this.rdBarcode.UseVisualStyleBackColor = true;
            this.rdBarcode.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(645, 440);
            this.Controls.Add(this.rdBarcode);
            this.Controls.Add(this.rdQrCode);
            this.Controls.Add(this.isLogo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtQr);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Qr);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_barcode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_barcode;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label Qr;
        private System.Windows.Forms.TextBox txtQr;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.CheckBox isLogo;
        private System.Windows.Forms.RadioButton rdQrCode;
        private System.Windows.Forms.RadioButton rdBarcode;
    }
}

