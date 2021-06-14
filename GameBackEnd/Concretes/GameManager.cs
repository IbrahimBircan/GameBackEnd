using GameBackEnd.Abstracts;
using GameBackEnd.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackEnd.Concretes
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + " adlı oyun eklendi");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + " adlı oyun silindi");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + " adlı oyun güncellendi");
        }
    }
}
