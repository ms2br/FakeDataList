using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataList
{
    internal class  Personel
    {
        public int Id { get; set; }
        public string Isim { get; set; }
        public string SoyIsim { get; set; }
        public string Ulke { get; set; }
        public string Ilce { get; set; }
        public string Il { get; set; }
        public string FirmaAdi { get; set; }
        public List<PersonelIletisimBilgileri> PersonleInfo = new List<PersonelIletisimBilgileri>();

        public Personel()
        { 
            PersonleInfo.Add(new PersonelIletisimBilgileri());
        }
    }
}
