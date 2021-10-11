using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    interface IGameManager
    {
        void AddGame(IGame game);
        void DeleteGame(IGame game);
        void ChangePrice(IGame game);
    }
}
