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
using System.Drawing;
using System.Windows.Forms;
using Savas.Library.Enum;


namespace Savas.Library.Abstract
{
    internal abstract class HareketliNesne : PictureBox
    {
        public Size HareketAlaniBoyutlari { get; }

        public int HareketMesafesi { get; protected set; }

        public new int Right
        {
            get => base.Right;
            set => Left = value - Width;
        }

        public new int Bottom
        {
            get => base.Bottom;
            set => Top = value - Height;
        }

        public int Center
        {
            get => Top + Height / 2;
            set => Top = value - Height / 2;          
        }

        public int Middle
        {
            get => Top + Height / 2;
            set => Top = value - Height / 2;
        }

        protected HareketliNesne(Size hareketAlaniBoyutlari)
        {
            Image = Image.FromFile($@"Gorseller\{GetType().Name}.png");
            HareketAlaniBoyutlari = hareketAlaniBoyutlari;
            SizeMode = PictureBoxSizeMode.AutoSize;
        }

        public bool HareketEttir(Yon yon)
        {
            switch (yon)
            {
                case Yon.Yukari:
                    return YukariHareketEttir();
                case Yon.Saga:
                    return SagaHareketEttir();
                case Yon.Asagi:
                    return AsagiHareketEttir();
                case Yon.Sola:
                    return SolaHareketEttir();
                default:
                    throw new ArgumentOutOfRangeException(nameof(yon), yon, null);
            }
        }

        private bool SolaHareketEttir()
        {
            if (Left == 0) return true;

            var yeniLeft = Left - HareketMesafesi;
            var sinirGecilecekMi = yeniLeft < 0;
            Left = sinirGecilecekMi ? 0 : yeniLeft;

            return Left == 0;
        }



        private bool AsagiHareketEttir()
        {
            if (Bottom == HareketAlaniBoyutlari.Height) return true;

            var yeniBottom = Bottom + HareketMesafesi;
            var sinirGecilecekMi = yeniBottom > HareketAlaniBoyutlari.Height;

            Bottom = sinirGecilecekMi ? HareketAlaniBoyutlari.Height : yeniBottom;

            return Bottom == HareketAlaniBoyutlari.Height;
        }

        private bool SagaHareketEttir()
        {
            if (Right == HareketAlaniBoyutlari.Width) return true;

            var yeniRight = Right + HareketMesafesi;
            var sinirGecilecekMi = yeniRight > HareketAlaniBoyutlari.Width;

            Right = sinirGecilecekMi ? HareketAlaniBoyutlari.Width : yeniRight;

            return Right == HareketAlaniBoyutlari.Width;
        }


        private bool YukariHareketEttir()
        {
            if (Top == 0) return true;

            var yeniTop = Top - HareketMesafesi;
            var sinirGecilecekMi = yeniTop < 0;
            Top = sinirGecilecekMi ? 0 : yeniTop;

            return Top == 0;
        }
    }
}
