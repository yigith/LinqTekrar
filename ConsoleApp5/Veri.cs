﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public static class Veri
    {
        public static List<Kisi> Kisiler()
        {
            return new List<Kisi>()
            {
                new Kisi() { Id = 1, Ad = "Selin", SehirId = 34 },
                new Kisi() { Id = 2, Ad = "Yiğit", SehirId = 6 }
            };
        }
        public static List<Sehir> Sehirler()
        {
            return new List<Sehir>
            {
                new Sehir() { Id = 1, SehirAd = "Adana"},
                new Sehir() { Id = 2, SehirAd = "Adıyaman"},
                new Sehir() { Id = 3, SehirAd = "Afyonkarahisar"},
                new Sehir() { Id = 4, SehirAd = "Ağrı"},
                new Sehir() { Id = 5, SehirAd = "Amasya"},
                new Sehir() { Id = 6, SehirAd = "Ankara"},
                new Sehir() { Id = 7, SehirAd = "Antalya"},
                new Sehir() { Id = 8, SehirAd = "Artvin"},
                new Sehir() { Id = 9, SehirAd = "Aydın"},
                new Sehir() { Id = 10, SehirAd = "Balıkesir"},
                new Sehir() { Id = 11, SehirAd = "Bilecik"},
                new Sehir() { Id = 12, SehirAd = "Bingöl"},
                new Sehir() { Id = 13, SehirAd = "Bitlis"},
                new Sehir() { Id = 14, SehirAd = "Bolu"},
                new Sehir() { Id = 15, SehirAd = "Burdur"},
                new Sehir() { Id = 16, SehirAd = "Bursa"},
                new Sehir() { Id = 17, SehirAd = "Çanakkale"},
                new Sehir() { Id = 18, SehirAd = "Çankırı"},
                new Sehir() { Id = 19, SehirAd = "Çorum"},
                new Sehir() { Id = 20, SehirAd = "Denizli"},
                new Sehir() { Id = 21, SehirAd = "Diyarbakır"},
                new Sehir() { Id = 22, SehirAd = "Edirne"},
                new Sehir() { Id = 23, SehirAd = "Elazığ"},
                new Sehir() { Id = 24, SehirAd = "Erzincan"},
                new Sehir() { Id = 25, SehirAd = "Erzurum"},
                new Sehir() { Id = 26, SehirAd = "Eskişehir"},
                new Sehir() { Id = 27, SehirAd = "Gaziantep"},
                new Sehir() { Id = 28, SehirAd = "Giresun"},
                new Sehir() { Id = 29, SehirAd = "Gümüşhane"},
                new Sehir() { Id = 30, SehirAd = "Hakkari"},
                new Sehir() { Id = 31, SehirAd = "Hatay"},
                new Sehir() { Id = 32, SehirAd = "Isparta"},
                new Sehir() { Id = 33, SehirAd = "Mersin"},
                new Sehir() { Id = 34, SehirAd = "İstanbul"},
                new Sehir() { Id = 35, SehirAd = "İzmir"},
                new Sehir() { Id = 36, SehirAd = "Kars"},
                new Sehir() { Id = 37, SehirAd = "Kastamonu"},
                new Sehir() { Id = 38, SehirAd = "Kayseri"},
                new Sehir() { Id = 39, SehirAd = "Kırklareli"},
                new Sehir() { Id = 40, SehirAd = "Kırşehir"},
                new Sehir() { Id = 41, SehirAd = "Kocaeli"},
                new Sehir() { Id = 42, SehirAd = "Konya"},
                new Sehir() { Id = 43, SehirAd = "Kütahya"},
                new Sehir() { Id = 44, SehirAd = "Malatya"},
                new Sehir() { Id = 45, SehirAd = "Manisa"},
                new Sehir() { Id = 46, SehirAd = "Kahramanmaraş"},
                new Sehir() { Id = 47, SehirAd = "Mardin"},
                new Sehir() { Id = 48, SehirAd = "Muğla"},
                new Sehir() { Id = 49, SehirAd = "Muş"},
                new Sehir() { Id = 50, SehirAd = "Nevşehir"},
                new Sehir() { Id = 51, SehirAd = "Niğde"},
                new Sehir() { Id = 52, SehirAd = "Ordu"},
                new Sehir() { Id = 53, SehirAd = "Rize"},
                new Sehir() { Id = 54, SehirAd = "Sakarya"},
                new Sehir() { Id = 55, SehirAd = "Samsun"},
                new Sehir() { Id = 56, SehirAd = "Siirt"},
                new Sehir() { Id = 57, SehirAd = "Sinop"},
                new Sehir() { Id = 58, SehirAd = "Sivas"},
                new Sehir() { Id = 59, SehirAd = "Tekirdağ"},
                new Sehir() { Id = 60, SehirAd = "Tokat"},
                new Sehir() { Id = 61, SehirAd = "Trabzon"},
                new Sehir() { Id = 62, SehirAd = "Tunceli"},
                new Sehir() { Id = 63, SehirAd = "Şanlıurfa"},
                new Sehir() { Id = 64, SehirAd = "Uşak"},
                new Sehir() { Id = 65, SehirAd = "Van"},
                new Sehir() { Id = 66, SehirAd = "Yozgat"},
                new Sehir() { Id = 67, SehirAd = "Zonguldak"},
                new Sehir() { Id = 68, SehirAd = "Aksaray"},
                new Sehir() { Id = 69, SehirAd = "Bayburt"},
                new Sehir() { Id = 70, SehirAd = "Karaman"},
                new Sehir() { Id = 71, SehirAd = "Kırıkkale"},
                new Sehir() { Id = 72, SehirAd = "Batman"},
                new Sehir() { Id = 73, SehirAd = "Şırnak"},
                new Sehir() { Id = 74, SehirAd = "Bartın"},
                new Sehir() { Id = 75, SehirAd = "Ardahan"},
                new Sehir() { Id = 76, SehirAd = "Iğdır"},
                new Sehir() { Id = 77, SehirAd = "Yalova"},
                new Sehir() { Id = 78, SehirAd = "Karabük"},
                new Sehir() { Id = 79, SehirAd = "Kilis"},
                new Sehir() { Id = 80, SehirAd = "Osmaniye"},
                new Sehir() { Id = 81, SehirAd = "Düzce"}
            };
        }
    }
}
