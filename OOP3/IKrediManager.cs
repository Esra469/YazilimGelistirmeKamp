using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    //İnterface ise o clas içerideki metotları sağlamak zorunda
    interface IKrediManager
    {
        //Bu interface kural içerir bunları içeren sınıflar bu kurallara uymak zorunda.
        void Hesapla();
        void BiseyYap();

    }
}
