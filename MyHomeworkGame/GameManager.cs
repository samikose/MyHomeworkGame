using System;
using System.Collections.Generic;
using System.Text;

namespace MyHomeworkGame
{
    class GameManager
    {
        public void Add(Game game)
        {
            Console.WriteLine("Oyun sepetinize eklenmiştir");
            game.SalesQuantity += 1;
        }

        public void Delete(Game game)
        {
            Console.WriteLine("Oyun sepetinizden çıkarılmıştır");
            game.SalesQuantity -= 1;
        }
        public void Return(Game game)
        {
            Console.WriteLine("Oyun iade edilmiştir.Iade alınan ücret: "+game.Price);
            
        }

        public void InformationList(Game game)
        {
            Console.WriteLine("Oyun bilgileri: "+"Oyun adı:"+game.GameName+ " " +"Kategori: "+game.GameCategory+ " " +"OyunFiyatı: "+game.Price+ " " +"Satış Adedi: "+game.SalesQuantity );
        }
    }
}
