using ikili_taban;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stenografi_sifrecozme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            binaryArray = new BinaryArray();
        }
        Bitmap cozgoruntu;
        BinaryArray binaryArray;

        private void Seç_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            openFileDialog1.Title = "Bir dosya seçiniz.";
            openFileDialog1.Filter = "Jpeg Dosyaları (*.jpeg)|Jpg Dosyaları (*.jpg)";
            string dosyaYolu = openFileDialog1.FileName;

            textBox2.Text = dosyaYolu;

            pictureBox1.Image = Image.FromFile(dosyaYolu);
        }

        private void coz_Click(object sender, EventArgs e)
        {
            int[] cozum = new int[8];
            cozgoruntu = new Bitmap(pictureBox1.Image);
            int pixelIndex = 0;

            ///////////////////////////////////////////////////////

            int veri = Convert.ToInt32(textBox1.Text);
            string text = string.Empty;

            for (int i = 0; i < veri; i++)
            {
                Color cozrenk = cozgoruntu.GetPixel(0, pixelIndex);
                int[] cozred = binaryArray.Dizi(cozrenk.R);
                cozum[0] = cozred[7];

                int[] cozgreen = binaryArray.Dizi(cozrenk.G);
                cozum[1] = cozgreen[7];

                int[] cozblue = binaryArray.Dizi(cozrenk.B);
                cozum[2] = cozblue[7];

                Color cozrenk2 = cozgoruntu.GetPixel(0, pixelIndex + 1);
                int[] cozred2 = binaryArray.Dizi(cozrenk2.R);
                cozum[3] = cozred2[7];

                int[] cozgreen2 = binaryArray.Dizi(cozrenk2.G);
                cozum[4] = cozgreen2[7];

                int[] cozblue2 = binaryArray.Dizi(cozrenk2.B);
                cozum[5] = cozblue2[7];

                Color cozrenk3 = cozgoruntu.GetPixel(0, pixelIndex + 2);
                int[] cozred3 = binaryArray.Dizi(cozrenk3.R);
                cozum[6] = cozred3[7];

                int[] cozgreen3 = binaryArray.Dizi(cozrenk3.G);
                cozum[7] = cozgreen3[7];

                int sayi = binaryArray.Array(cozum);
                char character = (char)sayi;
                text += character;

                pixelIndex = pixelIndex + 3;
                label3.Text = text;

            }
            /////////////////////////////////////////////////////////////////////////////
        }
    }
}
