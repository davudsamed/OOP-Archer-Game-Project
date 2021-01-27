using System;
using System.Collections.Generic;
using System.Drawing;
using Savas.Library.Abstract;

namespace Savas.Library.Concrete
{
    internal class YesilBalon : Balon
    {
        private static readonly Random Random = new Random();

        public YesilBalon(Size hareketAlaniBoyutlari) : base(hareketAlaniBoyutlari)
        {
          HareketMesafesi = (int)(Height * .1);
          Left = Random.Next(hareketAlaniBoyutlari.Width - Width);
        }

    }
}
