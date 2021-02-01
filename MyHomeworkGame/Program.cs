using System;
using System.Collections.Generic;

namespace MyHomeworkGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            player.FirstName = "SAMİ";
            player.LastName = "KÖSE";
            player.Tc = 12345678900;
            player.BirthYear = 2002;

            PlayerManager playerManager = new PlayerManager(new UserValidationManager());
            playerManager.Add(player);
            playerManager.Delete(player);
            playerManager.Update(player);
            playerManager.InformationList(player);

            Game game = new Game();
            game.GameName = "Rust";
            game.GameCategory = "Hayatta Kalma";
            game.Price = 60;
            game.SalesQuantity = 1500;

            GameManager gameManager = new GameManager();
            gameManager.Add(game);
            gameManager.Delete(game);
            gameManager.Return(game);
            gameManager.InformationList(game);

            BlackFridayCampaign blackFridayCampaign = new BlackFridayCampaign();
            blackFridayCampaign.CampaignSalePrice(game);

            NewYearCampaign newYearCampaign = new NewYearCampaign();
            newYearCampaign.CampaignSalePrice(game);
        }
    }
}
