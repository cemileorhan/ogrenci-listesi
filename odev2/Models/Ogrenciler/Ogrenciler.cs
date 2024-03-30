using System.Drawing;
using System;
using System.Collections.Generic;

namespace odev2.Models.Ogrenciler
{
    public class Ogrenciler
    {
        public static List<Models.OgrenciBil> kOgrenci = new List<OgrenciBil>
        {
            new Models.OgrenciBil
            {
                OgrenciNo = 20155026,
                Ad = "Cemile",
                Soyad = "Orhan",
                Sinif = 3,
                DersTanimi = "Computer Graphics",
                Kredi = 4,
                SinavTarihi = Convert.ToDateTime("19/11/2023"),
                Vize = 46,
                Final = 93,
                Ortalama = (46 * 0.4) + (93 * 0.6),
                HarfKarsiligi = "BB",
                GecmeDurumu = (((46 * 0.4) + (93 * 0.6)) >= 60) ? "Geçti" : "Kaldı",
            },
            new Models.OgrenciBil
            {
                OgrenciNo = 20155031,
                Ad = "Özge Ece",
                Soyad = "Demirhan",
                Sinif = 3,
                DersTanimi = "Bilgisayar Ağları",
                Kredi = 4,
                SinavTarihi = Convert.ToDateTime("20/11/2023"),
                Vize = 80,
                Final = 60,
                Ortalama = (80 * 0.4) + (60 * 0.6),
                HarfKarsiligi = "CB",
                GecmeDurumu = (((80 * 0.4) + (60 * 0.6)) >= 60) ? "Geçti" : "Kaldı",
            },
            new Models.OgrenciBil
            {
                OgrenciNo = 20155020,
                Ad = "Eren",
                Soyad = "Şevik",
                Sinif = 3,
                DersTanimi = "Sistem Programlama",
                Kredi = 4,
                SinavTarihi = Convert.ToDateTime("21/11/2023"),
                Vize = 84,
                Final = 75,
                Ortalama = (84 * 0.4) + (75 * 0.6),
                HarfKarsiligi = "BB",
                GecmeDurumu = (((84 * 0.4) + (75 * 0.6)) >= 60) ? "Geçti" : "Kaldı",
            },
            new Models.OgrenciBil
            {
                OgrenciNo = 20155035,
                Ad = "Elif Ekin",
                Soyad = "Biçer",
                Sinif = 3,
                DersTanimi = "Mobile Devices",
                Kredi = 4,
                SinavTarihi = Convert.ToDateTime("15/11/2023"),
                Vize = 100,
                Final = 50,
                Ortalama = (100 * 0.4) + (50 * 0.6),
                HarfKarsiligi = "BB",
                GecmeDurumu = (((100 * 0.4) + (50 * 0.6)) >= 60) ? "Geçti" : "Kaldı",
            },
            new Models.OgrenciBil
            {
                OgrenciNo = 20155029,
                Ad = "Hatice Asude",
                Soyad = "Erbil",
                Sinif = 3,
                DersTanimi = "Psikolojiye Giriş",
                Kredi = 4,
                SinavTarihi = Convert.ToDateTime("22/11/2023"),
                Vize = 100,
                Final = 100,
                Ortalama = (100 * 0.4) + (100 * 0.6),
                HarfKarsiligi = "AA",
                GecmeDurumu = (((100 * 0.4) + (100 * 0.6)) >= 60) ? "Geçti" : "Kaldı",
            },


        };
    }
}
