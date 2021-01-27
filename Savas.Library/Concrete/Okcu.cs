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
using System.Drawing;
using Savas.Library.Abstract;

namespace Savas.Library.Concrete
{
    internal class Okcu : HareketliNesne
    {
        public Okcu(int panelGenisligi, Size hareketAlaniBoyutlari) : base(hareketAlaniBoyutlari)
        {
            Center = panelGenisligi / 2;
            HareketMesafesi = Width/4;
        }
    }
}
