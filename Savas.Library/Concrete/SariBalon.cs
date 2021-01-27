using System;
using System.Collections.Generic;
using System.Drawing;
using Savas.Library.Abstract;

namespace Savas.Library.Concrete
{
    class SariBalon : Balon
    {
        private static readonly Random Random = new Random();

        public SariBalon(Size hareketAlaniBoyutlari) : base(hareketAlaniBoyutlari)
        {
            HareketMesafesi = (int)(Height * .1);
            Left = Random.Next(hareketAlaniBoyutlari.Width - Width);
        }

    }
}
