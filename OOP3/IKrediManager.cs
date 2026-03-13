using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    //interface referans tutucu
    //İnterface ise o clas içerideki metotları sağlamak zorunda
    //bilgiler farklı olan yapılar
    interface IKrediManager
    {
        //Bu interface kural içerir bunları içeren sınıflar bu kurallara uymak zorunda.
        void Hesapla();
        void BiseyYap();

    }
}
