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

namespace Stenografi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            binaryArray = new BinaryArray();
        }

        Bitmap goruntu;
        Bitmap goruntu2;
        BinaryArray binaryArray;

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog resim = new OpenFileDialog();
            resim.ShowDialog();
            string dosya = resim.FileName;

            pictureBox1.Image = Image.FromFile(dosya);
        }


        private string GetArrayString(int[] array)
        {
            string arrayStr = string.Empty;

            for (int i = 0; i < array.Length; i++)
            {
                arrayStr += array[i].ToString();
            }

            return arrayStr;
        }

        private void btnChepper_Click(object sender, EventArgs e)
        {
            goruntu = new Bitmap(pictureBox1.Image);
            goruntu2 = new Bitmap(pictureBox1.Image);

            int pixelIndex = 0;
            for (int i = 0; i < txtChepper.Text.Length; i++)
            {
                string sifre = txtChepper.Text;
                char harf = sifre[i];
                int ascii = Convert.ToInt32(harf);
                int[] array = binaryArray.Dizi(ascii);

                Color renk = goruntu.GetPixel(0, pixelIndex);
                int[] arrayred = binaryArray.Dizi(renk.R);
                arrayred[7] = array[0];

                int red = binaryArray.Array(arrayred);

                int[] arraygreen = binaryArray.Dizi(renk.G);
                arraygreen[7] = array[1];

                int green = binaryArray.Array(arraygreen);

                int[] arrayblue = binaryArray.Dizi(renk.B);
                arrayblue[7] = array[2];

                int blue = binaryArray.Array(arrayblue);

                Color a = Color.FromArgb(red, green, blue);
                goruntu2.SetPixel(0, pixelIndex, a);

                Color renk2 = goruntu.GetPixel(0, pixelIndex + 1);

                int[] arrayred2 = binaryArray.Dizi(renk2.R);
                arrayred2[7] = array[3];

                red = binaryArray.Array(arrayred2);

                int[] arraygreen2 = binaryArray.Dizi(renk2.G);
                arraygreen2[7] = array[4];

                green = binaryArray.Array(arraygreen2);

                int[] arrayblue2 = binaryArray.Dizi(renk2.B);
                arrayblue2[7] = array[5];

                blue = binaryArray.Array(arrayblue2);

                a = Color.FromArgb(red, green, blue);
                goruntu2.SetPixel(0, pixelIndex + 1, a);

                Color renk3 = goruntu.GetPixel(0, pixelIndex + 2);
                int[] arrayred3 = binaryArray.Dizi(renk3.R);
                arrayred3[7] = array[6];

                red = binaryArray.Array(arrayred3);

                int[] arraygreen3 = binaryArray.Dizi(renk3.G);
                arraygreen3[7] = array[7];

                green = binaryArray.Array(arraygreen3);

                a = Color.FromArgb(red, green, renk3.B);
                goruntu2.SetPixel(0, pixelIndex + 2, a);

                pixelIndex = pixelIndex + 3;
            }

            pbChepper.Image = goruntu2;
        }

        private void Kaydet_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            saveFileDialog1.Title = "JPG olarak kaydet.";
            sfd.Filter = "JPG(.JPG)|*.jpg";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                goruntu2.Save(sfd.FileName);
            }

        }
    }
}

