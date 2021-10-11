using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class GameManager : IGameManager
    {
        public void AddGame(IGame game)
        {
            Console.WriteLine(game.GameName+ " has added.");
        }

        public void ChangePrice(IGame game)
        {
            Console.WriteLine(game.GameName + " 's price has changed.");
        }

        public void DeleteGame(IGame game)
        {
            Console.WriteLine(game.GameName + " has deleted.");
        }
    }
}
