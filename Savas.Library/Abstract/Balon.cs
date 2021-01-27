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
using System.Collections.Generic;
using System.Drawing;
using Savas.Library.Concrete;

namespace Savas.Library.Abstract
{
    class Balon : HareketliNesne
    {
        private static readonly Random Random = new Random();

        public Balon(Size hareketAlaniBoyutlari) : base(hareketAlaniBoyutlari)
        {
            HareketMesafesi = (int)(Height * .1);
            Left = Random.Next(hareketAlaniBoyutlari.Width - Width);
        }
        public Ok VurulduMu(List<Ok> oklar)
        {
            foreach (var ok in oklar)
            {
                var vurulduMu = (ok.Right > Left && ok.Right < Right && ok.Top < Bottom && ok.Bottom > Top) ||
                                (ok.Left > Left && ok.Left < Right && ok.Top < Bottom && ok.Bottom > Top);
                if (vurulduMu) return ok;
            }

            return null;
        }












    }
}
