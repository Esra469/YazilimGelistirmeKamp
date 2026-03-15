using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    //microservice
    //Hiçbir sınıf boş kalmamalı. Gamerservice somut kısmı 
    internal class GamerManager : IGamerService
    {
        //Bir sınıf içinde yeni bir manager sınıf kullanacaksak asla onu new leme onun yerine constraction kullan
        IUserValidationService _userValidationService;
        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService; 
        }
        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validation(gamer) == true)
            {
                   Console.WriteLine("Kayıt oldu");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız.Kayıt başarısız");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt Güncellendi");
        }
    }
}
