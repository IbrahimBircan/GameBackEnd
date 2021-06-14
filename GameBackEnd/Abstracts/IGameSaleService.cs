using GameBackEnd.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackEnd.Abstracts
{
    interface IGameSaleService
    {
        void Sale(Gamer gamer, Game game, Campaign campaign);
    }
}
