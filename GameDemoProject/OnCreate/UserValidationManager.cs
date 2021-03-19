using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemoProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.FirstName=="Yunus" && gamer.LastName=="Öztürk"&& gamer.TcNo == "14356789345"&& gamer.BirthOfDay== "01.08.2002")
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

