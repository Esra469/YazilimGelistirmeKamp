using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    //doğrulama için ilk bir soyut şablon oluşturduk.
    internal interface IUserValidationService
    {
        bool Validation(Gamer gamer);

    }
}
