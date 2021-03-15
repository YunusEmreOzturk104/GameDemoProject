using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemoProject
{
    class ValidationManager : IValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.FirstName=="ibrahim"&& gamer.TcNo=="345535543"&&gamer.LastName=="demirelli"&&gamer.BirthOfDay=="17.07.2002")
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

