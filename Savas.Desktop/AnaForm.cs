/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2019-2020 Yaz Okulu
**	
**				ÖDEV NUMARASI..........:1
**				ÖĞRENCİ ADI............:Davud Samed Tombul
**				ÖĞRENCİ NUMARASI.......:B171210007
**              DERSİN ALINDIĞI GRUP...:1A
****************************************************************************/
using System;
using System.Windows.Forms;
using Savas.Library.Concrete;
using Savas.Library.Enum;

namespace Savas.Desktop
{
    public partial class AnaForm : Form
    {
        private readonly Oyun balonOyunu;
        
        public AnaForm()
        {
            InitializeComponent();

            balonOyunu = new Oyun(okcuPanel, aksiyonPanel);
            balonOyunu.GecenSureDegisti += Oyun_GecenSureDegisti;
        }

        private void AnaForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                        balonOyunu.Baslat();
                    break;
                case Keys.Up:
                    balonOyunu.OkcuHareketEttir(Yon.Yukari);//
                    break;
                case Keys.Down:
                    balonOyunu.OkcuHareketEttir(Yon.Asagi);//
                    break;
                case Keys.Space:
                    balonOyunu.OkAt();
                    break;
            }
        }

        private void Oyun_GecenSureDegisti(object sender, EventArgs e)
        {
            lbl_over.Text = balonOyunu.GecenSure.ToString(@"m\:ss");
            skorLabel.Text = balonOyunu.skor.ToString();                /////////////
            asamaLabel.Text ="AŞAMA "+ balonOyunu.asama.ToString();
        }


    }
}
