using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemoProject
{
    interface IGamerService
    {
        void Add(List<Gamer> gamers);
        void Delete(List<Gamer> gamers);
        void Update(List<Gamer> gamers);
    }
}
