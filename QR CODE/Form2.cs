using System;
using System.Drawing;
using System.Windows.Forms;
using ZXing;

namespace QrCodeReader
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1(object sender, EventArgs e)
        {
            var barcodeReader = new BarcodeReader();

            if (pictureBox.Image != null)
            {
                var bitmap = new Bitmap(pictureBox.Image);
                var result = barcodeReader.Decode(bitmap);

                if (result != null)
                {
                    MessageBox.Show("QR kodu verisi: " + result.Text, "QR Kodu Okundu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("QR kodu okunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pictureBox1(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PNG dosyaları|*.png|JPEG dosyaları|*.jpg|Bütün dosyalar|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = Image.FromFile(openFileDialog.FileName);
            }
        }
    }
}
