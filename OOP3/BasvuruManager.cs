using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
     class BasvuruManager
    {
        //method injection
        public void BasvuruYap(IKrediManager krediManager,ILoggerService loggerService)
        {
            //Başvuru bilgilerini değerlendirme.
           // bu şekilde sadece konut çağırırz tüm hesaplamalar buradan olur KonutKrediManager konutKrediManager = new KonutKrediManager();

            //ama yukarıda Interfaceyi belirtirsek ordan hesapla dediğimzde verdiğimiz parametreye göre bağlı olan kredi tipi hesaplanacak

            krediManager.Hesapla();
            loggerService.Log();
        }
        //birden fazla kredi seçme durumunda, bana bir liste ver ama bu listenin türü IKrediManager olsun 
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();//her bir kredinin hesabını yap
            }
        }
    }
}
