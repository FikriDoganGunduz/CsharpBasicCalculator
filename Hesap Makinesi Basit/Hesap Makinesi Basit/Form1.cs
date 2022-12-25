using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinesi_Basit
{
    public partial class Form1 : Form
    {
        private char _islem;
        private bool _ekranTemizleme;
        private int _ilkSayı;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (_ekranTemizleme) 
                EkranLabel.Text = "";
            _ekranTemizleme = false;

            if (EkranLabel.Text == "0") EkranLabel.Text = "";
            EkranLabel.Text += "1";
        }
          //Kopyala yapıştır zamanı xd
        private void btn2_Click(object sender, EventArgs e)
        {
            if (_ekranTemizleme)
                EkranLabel.Text = "";
            _ekranTemizleme = false;

            if (EkranLabel.Text == "0") EkranLabel.Text = "";
            EkranLabel.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (_ekranTemizleme)
                EkranLabel.Text = "";
            _ekranTemizleme = false;

            if (EkranLabel.Text == "0") EkranLabel.Text = "";
            EkranLabel.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (_ekranTemizleme)
                EkranLabel.Text = "";
            _ekranTemizleme = false;

            if (EkranLabel.Text == "0") EkranLabel.Text = "";
            EkranLabel.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (_ekranTemizleme)
                EkranLabel.Text = "";
            _ekranTemizleme = false;

            if (EkranLabel.Text == "0") EkranLabel.Text = "";
            EkranLabel.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (_ekranTemizleme)
                EkranLabel.Text = "";
            _ekranTemizleme = false;

            if (EkranLabel.Text == "0") EkranLabel.Text = "";
            EkranLabel.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (_ekranTemizleme)
                EkranLabel.Text = "";
            _ekranTemizleme = false;

            if (EkranLabel.Text == "0") EkranLabel.Text = "";
            EkranLabel.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (_ekranTemizleme)
                EkranLabel.Text = "";
            _ekranTemizleme = false;

            if (EkranLabel.Text == "0") EkranLabel.Text = "";
            EkranLabel.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (_ekranTemizleme)
                EkranLabel.Text = "";
            _ekranTemizleme = false;

            if (EkranLabel.Text == "0") EkranLabel.Text = "";
            EkranLabel.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (_ekranTemizleme)
                EkranLabel.Text = "";
            _ekranTemizleme = false;

            if (EkranLabel.Text == "0") EkranLabel.Text = "";
            EkranLabel.Text += "0";
        }

        private void btnArtı_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekranTemizleme = true;
            _ilkSayı = Convert.ToInt32(EkranLabel.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ikinciSayi = Convert.ToInt32(EkranLabel.Text);
            int sonuc;
            
            switch (_islem)
            {
                case '+':
                    sonuc = _ilkSayı + ikinciSayi;
                    break;
                case '-':
                    sonuc = _ilkSayı - ikinciSayi;
                    break;
                case '*':
                    sonuc = _ilkSayı * ikinciSayi;
                    break;
                case '/':
                    sonuc = _ilkSayı / ikinciSayi;
                    break;
                default:
                    sonuc = 0;
                    break;
             }

            EkranLabel.Text = Convert.ToString(sonuc);
        
        }
        //ı can be a supermannnnnnnn
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEksi_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekranTemizleme = true;
            _ilkSayı = Convert.ToInt32(EkranLabel.Text);
        }

        private void btnCarpma_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _ekranTemizleme = true;
            _ilkSayı = Convert.ToInt32(EkranLabel.Text);
        }

        private void btnBolme_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekranTemizleme = true;
            _ilkSayı = Convert.ToInt32(EkranLabel.Text);
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            EkranLabel.Text = "0";
        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAltaAlma_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            //adios amigos :D 
        }
    }
}
