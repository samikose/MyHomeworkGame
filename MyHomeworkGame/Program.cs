﻿using System;
using System.Collections.Generic;

namespace MyHomeworkGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            player.FirstName = "Sami";
            player.LastName = "Kose";
            player.Tc = 37018039180;

            PlayerManager playerManager = new PlayerManager();
            playerManager.Add();
            playerManager.Delete();
            playerManager.Update();
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
