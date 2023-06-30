using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;
using ZXing.QrCode.Internal;
using ZXing.Rendering;
namespace qr_code_generatort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
                return;
            string imagepath;
            imagepath = Path.Combine(@"C:\CodeGenerated");
            if (!Directory.Exists(imagepath))
                Directory.CreateDirectory(imagepath);

            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "PNG|*.png" })
            {
                saveFileDialog.InitialDirectory = imagepath;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image.Save(saveFileDialog.FileName);
                    string dir = Path.GetDirectoryName(saveFileDialog.FileName);
                    Process.Start("explorer", dir);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                btn_barcode.PerformClick();
            }
        }

        private void btn_barcode_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtQr.Text))
            {
                if (rdQrCode.Checked)
                {
                    if (isLogo.Checked == true)
                    {

                        BarcodeWriter qrwriter = new BarcodeWriter();
                        EncodingOptions encodeOpt = new EncodingOptions() { Width = 300, Height = 300, Margin = 2, PureBarcode = false };
                        encodeOpt.Hints.Add(EncodeHintType.ERROR_CORRECTION, ErrorCorrectionLevel.H);
                        qrwriter.Renderer = new BitmapRenderer();
                        qrwriter.Options = encodeOpt;
                        qrwriter.Format = BarcodeFormat.QR_CODE;
                        Bitmap btimap = qrwriter.Write(txtQr.Text);
                        Bitmap logo = new Bitmap($"{Application.StartupPath}/logo.png");
                        Graphics g = Graphics.FromImage(btimap);
                        g.DrawImage(logo, new Point((btimap.Width - logo.Width) / 2, (btimap.Height - logo.Height) / 2));
                        pictureBox1.Image = btimap;
                    }
                    else
                    {
                        Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
                        pictureBox1.Image = qrcode.Draw(txtQr.Text, 50);
                    }
                }
                else
                {
                    //Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                    //pictureBox1.Image = barcode.Draw(txtQr.Text, 50);
                    
                    BarcodeWriter barcodeWriter = new BarcodeWriter
                    {
                        Format = BarcodeFormat.CODE_128,
                        Options = new EncodingOptions
                        {
                            Width = 300,
                            Height = 100
                        },
                        Renderer = new BitmapRenderer
                        {
                            Background = System.Drawing.Color.White,
                            Foreground = System.Drawing.Color.Black
                        }
                    };

                    Bitmap barcodeBitmap = barcodeWriter.Write(txtQr.Text);

                    //using (Graphics graphics = Graphics.FromImage(barcodeBitmap))
                    //{
                    //    using (Font font = new Font("Arial", 10))
                    //    {
                    //        SizeF textSize = graphics.MeasureString(txtQr.Text, font);
                    //        float x = (barcodeBitmap.Width - textSize.Width) / 2;
                    //        float y = barcodeBitmap.Height - textSize.Height - 5;
                    //        PointF textPoint = new PointF(x, y);
                    //       // pictureBox1.Image = barcodeBitmap;
                    //        graphics.DrawString(txtQr.Text, font, Brushes.Black, textPoint);

                    //    }
                    //}
                    //using (Graphics g = Graphics.FromImage(barcodeBitmap))
                    //{
                    //    using (Font font = new Font("Arial", 12))
                    //    {
                    //        string numbersText = txtQr.Text;
                    //        SizeF numbersSize = g.MeasureString(numbersText, font);
                    //        g.DrawString(numbersText, font, Brushes.Black, (barcodeBitmap.Width - numbersSize.Width) / 2, barcodeBitmap.Height - numbersSize.Height);
                    //    }
                    //}
                   
                    pictureBox1.Image = barcodeBitmap;

                }
            }
            else
            {
                MessageBox.Show("Please check if the textbox is empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void txtQr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                btn_barcode.PerformClick();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            rdQrCode.Checked = true;
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            string logoDir;
            logoDir = Path.Combine(Application.StartupPath, "logo.png");
            if (!File.Exists(logoDir))
            {
                MessageBox.Show("Please check if the logo.png exist in application Folder \n Width : 50px Height : 50px", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.S)
            {
                btn_Save.PerformClick();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBarcode.Checked)
            {
                isLogo.Visible = false;
            }
            else
            {
                isLogo.Visible = true;
            }


        }
    }
}
