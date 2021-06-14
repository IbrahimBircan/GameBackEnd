using System;
using GameBackEnd.Entities;
using GameBackEnd.Concretes;
using GameBackEnd.Adapters;

namespace GameBackEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game1 = new Game();
            game1.GameId = 1;
            game1.GameName = "Assassin Creed I";
            game1.GameCategory = "Aksiyon";
            game1.GamePrice = 31.50;


            Game game2 = new Game
            {
                GameId = 2,
                GameName = "Assasian Creed Black Flag",
                GameCategory = "Aksiyon",
                GamePrice = 55.10
            };

            Game game3 = new Game
            {
                GameId = 3,
                GameName = "Cull of Duty 5",
                GameCategory = "Savaş",
                GamePrice = 110.20
            };


            Console.WriteLine("---------------------------");

            Campaign campaign1 = new Campaign();
            campaign1.CampaignId = 12345;
            campaign1.CampaignName = "Bahar Kampanyası";
            campaign1.CampaignDiscount = 25;                   //--->  %25

            Campaign campaign2 = new Campaign();
            campaign2.CampaignId = 22223;
            campaign2.CampaignName = "Kış indirimleri";
            campaign2.CampaignDiscount=50;                      //--->  %50


            Console.WriteLine("--------------------------------");

            Gamer gamer1 = new Gamer
            {
                GamerId = 222,
                FirstName = "Halil ibrahim",
                LastName = "Bircan",
                DateOfBirth =new DateTime (1996,09,29),
                NationalityId="12345678901"
            };

            Gamer gamer2 = new Gamer();
            gamer2.GamerId = 333;
            gamer2.FirstName = "Ahmet";
            gamer2.LastName = "Bircan";
            gamer2.DateOfBirth = new DateTime(1962,06,02);
            gamer2.NationalityId = "12345678900";

            Console.WriteLine("--------------------------------------");

            GamerManager gamerManager = new GamerManager(new MernisCheckServiceAdapter());
            gamerManager.Add(gamer1);
            gamerManager.Add(gamer2);
            gamerManager.Delete(gamer2);
            gamerManager.Update(gamer1);

            Console.WriteLine("----------------------------------------");

            GameManager gameManager = new GameManager();
            gameManager.Add(game1);
            gameManager.Add(game2);
            gameManager.Add(game3);
            gameManager.Delete(game1);
            gameManager.Update(game2);
            gameManager.Update(game3);

            Console.WriteLine("------------------------------");

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Add(campaign2);
            campaignManager.Delete(campaign1);
            campaignManager.Update(campaign2);


            Console.WriteLine("---------------");

            GameSalesManager gameSalesManager = new GameSalesManager();
            gameSalesManager.Sale(gamer1, game2, campaign2);
            gameSalesManager.Sale(gamer2, game3, campaign2);




        }
    }
}
