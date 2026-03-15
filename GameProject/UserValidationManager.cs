using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class UserValidationManager : IUserValidationService
    {
        public bool Validation(Gamer gamer)
        {
            if(gamer.BirthYear==1985 && gamer.FirstName == "Esra" && 
                gamer.LastName=="Çimen" && gamer.IdentityNumber==12345)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
