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
using System.Windows.Forms;
using Savas.Library.Enum;
using Savas.Library.Abstract;

namespace Savas.Library.Concrete
{
    public class Oyun
    {
        private readonly Timer _gecenSureTimer = new Timer { Interval = 1000 };
        private readonly Timer _hareketTimer = new Timer { Interval = 75 };

        private readonly Timer yesiBalonOlusturmaTimer = new Timer { Interval = 1000};
        private readonly Timer sariBalonOlusturmaTimer = new Timer { Interval = 3000 };
        private readonly Timer kirmiziBalonOlusturmaTimer = new Timer { Interval = 4000};
        
        private TimeSpan _gecenSure;
        private readonly Panel okcuPanel;
        private readonly Panel aksiyon_Panel;
        private Okcu okcu;
        private readonly List<Ok> oklar = new List<Ok>();

        private readonly List<YesilBalon> _yesilBalonlar = new List<YesilBalon>();
        private readonly List<SariBalon> _sariBalonlar = new List<SariBalon>();
        private readonly List<KirmiziBalon> _kirmiziBalonlar = new List<KirmiziBalon>();
        public int skor = 0;
        public int asama = 1;
        public bool bittiMi = false;

        public event EventHandler GecenSureDegisti;

        public bool DevamEdiyorMu { get; private set; }

        public TimeSpan GecenSure
        {
            get => _gecenSure;
            private set
            {
                _gecenSure = value;

                GecenSureDegisti?.Invoke(this, EventArgs.Empty);
            }
        }

        //Balon türlerine ait fonksiyonlar bu regionlar içerisinde toplanıldı.
        #region Kirmizi
        public void AsamaUcBaslat()
        {
            DevamEdiyorMu = true;

            AsamaUcZamanlayicilariBaslat();

            KirmiziBalonOlustur();
        }
        private void KirmiziBalonOlustur()//1
        {
            var kirmiziBalon = new KirmiziBalon(aksiyon_Panel.Size);
            _kirmiziBalonlar.Add(kirmiziBalon);
            aksiyon_Panel.Controls.Add(kirmiziBalon);
        }

        private void KirmiziBalonlariHareketEttir()
        {
            foreach (var kirmiziBalon in _kirmiziBalonlar)
            {

                var vurduMu = kirmiziBalon.HareketEttir(Yon.Asagi);
                if (!vurduMu) continue;
                _kirmiziBalonlar.Remove(kirmiziBalon);
                aksiyon_Panel.Controls.Remove(kirmiziBalon);
                break;
            }
        }

        private void AsamaUcZamanlayicilariBaslat()
        {
            kirmiziBalonOlusturmaTimer.Start();
        }

        private void kirmiziBalonOlusturmaTimer_Tick(object sender, EventArgs e)
        {
            KirmiziBalonOlustur();
        }

        private void VurulanKirmiziBalonlariCikar()
        {
            for (var i = _kirmiziBalonlar.Count - 1; i >= 0; i--)
            {

                var kirmiziBalon = _kirmiziBalonlar[i];

                var vuranOk = kirmiziBalon.VurulduMu(oklar);
                if (vuranOk is null) continue;
                _kirmiziBalonlar.Remove(kirmiziBalon);
                oklar.Remove(vuranOk);
                aksiyon_Panel.Controls.Remove(kirmiziBalon);
                aksiyon_Panel.Controls.Remove(vuranOk);
                skor = 0;
                break;
            }
        }
        #endregion

        #region Sari
        private void AsamaIkıZamanlayicilariBaslat()
        {
            sariBalonOlusturmaTimer.Start();
        }

        private void VurulanSariBalonlariCikar()
        {
            for (var i = _sariBalonlar.Count - 1; i >= 0; i--)
            {

                var sariBalon = _sariBalonlar[i];

                var vuranOk = sariBalon.VurulduMu(oklar);
                if (vuranOk is null) continue;
                skor += 15;         ////////////////////
                _sariBalonlar.Remove(sariBalon);
                oklar.Remove(vuranOk);
                aksiyon_Panel.Controls.Remove(sariBalon);
                aksiyon_Panel.Controls.Remove(vuranOk);
            }
        }

        private void SariBalonlariHareketEttir()
        {
            foreach (var sariBalon in _sariBalonlar)
            {
                var vurduMu = sariBalon.HareketEttir(Yon.Asagi);
                if (!vurduMu) continue;
                Bitir();
                break;
            }
        }

        private void sariBalonOlusturmaTimer_Tick(object sender, EventArgs e)
        {
            SariBalonOlustur();
        }

        public void AsamaIkıBaslat()
        {
            DevamEdiyorMu = true;

            AsamaIkıZamanlayicilariBaslat();

            SariBalonOlustur();
        }

        private void SariBalonOlustur() /////////////////////////////////////
        {
            var sariBalon = new SariBalon(aksiyon_Panel.Size);
            _sariBalonlar.Add(sariBalon);
            aksiyon_Panel.Controls.Add(sariBalon);
        }

        #endregion

        #region Yesil

        public void Baslat()
        {
            if (DevamEdiyorMu) return;

            DevamEdiyorMu = true;

            ZamanlayicilariBaslat();

            OkcuOlustur();
            YesilBalonOlustur();
        }
        private void YesilBalonOlustur()
        {
            var yesilBalon = new YesilBalon(aksiyon_Panel.Size);
            _yesilBalonlar.Add(yesilBalon);
            aksiyon_Panel.Controls.Add(yesilBalon);
        }

        private void VurulanYesilBalonlariCikar()
        {
            for (var i = _yesilBalonlar.Count - 1; i >= 0; i--)
            {

                var yesilBalon = _yesilBalonlar[i];

                var vuranOk = yesilBalon.VurulduMu(oklar);
                if (vuranOk is null) continue;
                skor += 5;         ////////////////////
                _yesilBalonlar.Remove(yesilBalon);
                oklar.Remove(vuranOk);
                aksiyon_Panel.Controls.Remove(yesilBalon);
                aksiyon_Panel.Controls.Remove(vuranOk);
                if (skor >= 100 && skor < 200)
                    asama = 2;
                else if (skor >= 200)
                    asama = 3;
                if (skor > 100)
                {
                    AsamaIkıBaslat();
                }
                if (skor > 200)
                {
                    AsamaUcZamanlayicilariBaslat();
                }
            }
        }

        private void YesilBalonlariHareketEttir()
        {
            foreach (var yesilBalon in _yesilBalonlar)
            {
                var vurduMu = yesilBalon.HareketEttir(Yon.Asagi);
                if (!vurduMu) continue;

                Bitir();
                break;
            }
        }

        private void YesilBalonOlusturmaTimer_Tick(object sender, EventArgs e)
        {
            YesilBalonOlustur();
        }

        #endregion

        public Oyun(Panel okcu_Panel, Panel aksiyonPanel)
        {
            
            okcuPanel = okcu_Panel;
            aksiyon_Panel = aksiyonPanel;

            _gecenSureTimer.Tick += GecenSureTimer_Tick;
            _hareketTimer.Tick += HareketTimer_Tick;

            yesiBalonOlusturmaTimer.Tick += YesilBalonOlusturmaTimer_Tick;
            sariBalonOlusturmaTimer.Tick += sariBalonOlusturmaTimer_Tick; //YENİ
            kirmiziBalonOlusturmaTimer.Tick += kirmiziBalonOlusturmaTimer_Tick;//
        }

        private void GecenSureTimer_Tick(object sender, EventArgs e)
        {
            GecenSure += TimeSpan.FromSeconds(1);
        }

        private void HareketTimer_Tick(object sender, EventArgs e)
        {
            OklariHareketEttir();
            YesilBalonlariHareketEttir();
            SariBalonlariHareketEttir();//...
            KirmiziBalonlariHareketEttir();///...
            

            VurulanYesilBalonlariCikar();
            VurulanSariBalonlariCikar();//...
            VurulanKirmiziBalonlariCikar();//...
        }

        private void OklariHareketEttir()
        {
            for (int i = oklar.Count - 1; i >= 0; i--)
            {
                var ok = oklar[i];
                var vurduMu = ok.HareketEttir(Yon.Saga);
                if (vurduMu)
                {
                    oklar.Remove(ok);
                    aksiyon_Panel.Controls.Remove(ok);
                }
            }
        }

        private void ZamanlayicilariBaslat()
        {
            _gecenSureTimer.Start();
            _hareketTimer.Start();
            yesiBalonOlusturmaTimer.Start();
        }

        private void Bitir()
        {
            if (!DevamEdiyorMu) return;
            DevamEdiyorMu = false;
            ZamanlayicilariDurdur();
            aksiyon_Panel.Controls.Clear();
            okcuPanel.Controls.Clear();
            _yesilBalonlar.Clear();
            _sariBalonlar.Clear();
            _kirmiziBalonlar.Clear();
            MessageBox.Show("Balon Tabana Çarptı Oyun Bitti Puanınız: "+skor);
            skor = 0;
            bittiMi =true;
        }

        public void ZamanlayicilariDurdur()
        {
            _gecenSureTimer.Stop();
            _hareketTimer.Stop();
            yesiBalonOlusturmaTimer.Stop();
            sariBalonOlusturmaTimer.Stop();//
            kirmiziBalonOlusturmaTimer.Stop(); 
        }

        public void OkAt()
        {
            if (!DevamEdiyorMu) return;

            var ok = new Ok(aksiyon_Panel.Size, okcu.Center);
            oklar.Add(ok);
            aksiyon_Panel.Controls.Add(ok);
        }

        public void OkcuHareketEttir(Yon yon)
        {
            if (!DevamEdiyorMu) return;

            okcu.HareketEttir(yon);
        }

        private void OkcuOlustur()
        {
            okcu = new Okcu(okcuPanel.Height, okcuPanel.Size);//
            okcuPanel.Controls.Add(okcu);
        }

    }
}
