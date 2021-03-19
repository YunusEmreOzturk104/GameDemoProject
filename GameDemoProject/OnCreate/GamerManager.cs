using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemoProject
{
    class GamerManager : IGamerService
    {
        UserValidationManager _userValidationManager;
        public GamerManager(UserValidationManager userValidationManager)
        {
            _userValidationManager = userValidationManager;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationManager.Validate(gamer) == true)
            {
                Console.WriteLine("Kayıt Eklendi");
            }
            else
            {
                Console.WriteLine("kayıt basarısız");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt Silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt Güncellendi");
        }
    }
}
