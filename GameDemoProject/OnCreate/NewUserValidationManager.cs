using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemoProject
{
    class NewUserValidationManager : IValidationService
    {
        public bool Validate(Gamer gamer)
        {
            return true; //testin başarılı olduğunu belirtmek için
        }
    }
}
