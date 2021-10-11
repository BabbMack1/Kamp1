using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    interface IGame
    {
        public string GameName { get; set; }
        public float GamePrice { get; set; }
        public DateTime ReleaseDate { get; set; }

    }
}
