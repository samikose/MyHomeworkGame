using System;
using System.Collections.Generic;
using System.Text;

namespace MyHomeworkGame
{
    class PlayerManager
    {
        public void Add()
        {
            Console.WriteLine("Hesap eklendi");
        }

        public void Delete()
        {
            Console.WriteLine("Hesap sistemden silindi");
        }

        public void InformationList(Player player)
        {
            Console.WriteLine("Bilgileriniz: "+player.FirstName+" "+ player.LastName+" "+player.Tc);
        }

        public void Update()
        {
            Console.WriteLine("Bilgileriniz güncellendi");
        }
    }
}
