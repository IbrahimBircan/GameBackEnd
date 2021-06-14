using GameBackEnd.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackEnd.Entities
{
    public class Game

    {
        public int GameId { get; set; }
        public string GameName { get; set; }
        public string GameCategory { get; set; }
        public double GamePrice { get; set; }
    }
}
