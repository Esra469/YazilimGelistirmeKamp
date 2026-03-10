using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotlar
{
     class SepetManager
    {
        //naming convention
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete eklendi : "+urun.Adi);
        }
        public void Ekle2(string urunAdi,string urunAciklama,int urunFiyat)
        {
            Console.WriteLine(urunAdi,urunAciklama,urunFiyat);

        }
    }
}
