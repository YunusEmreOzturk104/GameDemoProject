using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemoProject
{
    class GamerManager : IGamerService
    {
        public GamerManager(NewUserValidationManager newUserValidationManager)
        {
        }

        public void Add(List<Gamer> gamers)
        {
            Console.WriteLine("Kayıt Eklendi");
        }

        public void Delete(List<Gamer> gamers)
        {
            Console.WriteLine("Kayıt Silindi");
        }

        public void Update(List<Gamer> gamers)
        {
            Console.WriteLine("Kayıt Güncellendi");
        }
    }
}
