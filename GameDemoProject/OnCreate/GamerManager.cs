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
            
        }

        public void Delete(List<Gamer> gamers)
        {
            throw new NotImplementedException();
        }

        public void Update(List<Gamer> gamers)
        {
            throw new NotImplementedException();
        }
    }
}
