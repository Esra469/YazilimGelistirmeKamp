using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //interface onu implemente eden classın referansını tutar.
            //Ekranda kullanılabilecek krediler
            IKrediManager ihtiyacKrediManager=new IhtiyacKrediManager();
           
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager =new KonutKrediManager();

            BasvuruManager basvuruManager = new BasvuruManager();
           // basvuruManager.BasvuruYap(ihtiyacKrediManager); 
           //istediğimiz kadar kredi tarzı ekleyebilir.
            List<IKrediManager> krediler=new List<IKrediManager>() { ihtiyacKrediManager};
            basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
