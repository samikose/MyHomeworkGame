using System;
using System.Collections.Generic;
using System.Text;

namespace MyHomeworkGame
{
    class NewYearCampaign : ICampaignService
    {
        public void CampaignAdd()
        {
            Console.WriteLine("This Campaign has been added");
        }

        public void CampaignDelete()
        {
            Console.WriteLine("This Campaign has been deleted");
        }

        public void CampaignSalePrice(Game game)
        {
            game.Price = game.Price - game.Price * 50 / 100;
            Console.WriteLine(game.GameName+" fiyatı: " + game.Price);
        }
    }
}
