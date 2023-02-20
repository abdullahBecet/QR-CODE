using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QR_CODE
{
    private void btnScan_Click(object sender, EventArgs e)
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

}
