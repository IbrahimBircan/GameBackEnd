using GameBackEnd.Abstracts;
using GameBackEnd.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackEnd.Concretes
{
    class GameSalesManager : IGameSaleService
    {
        public void Sale(Gamer gamer, Game game, Campaign campaign)
        {
            double newPrice = game.GamePrice - (game.GamePrice * (campaign.CampaignDiscount / 100));
            Console.WriteLine(game.GameName+" oyunu "+gamer.FirstName+gamer.LastName+" adlı kişiye "+campaign.CampaignDiscount+" indirim oranı ile"+newPrice+" fiyatına satılmıştır."+ "Oyunun indirimsiz fiyatı : " + game.GamePrice + " indirimden sonraki fiyatı : " + newPrice);
            
        }
    }
}
