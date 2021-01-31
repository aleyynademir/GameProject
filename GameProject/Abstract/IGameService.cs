using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IGameService
    {
        Games Add(Games games);
        Games Delete(List<Games> games);
        void Update(List<Games> games);
        void ListGames(List<Games> games);

        
    }
}
