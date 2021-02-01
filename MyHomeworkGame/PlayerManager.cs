using System;
using System.Collections.Generic;
using System.Text;

namespace MyHomeworkGame
{
    class PlayerManager:IPlayerService
    {
        IUserValidate _userValidateService;
        public PlayerManager(IUserValidateService userValidateService)
        {
           _userValidateService = userValidateService;
        }
        public void Add(Player)
        {
           if(_userValidateService.Validate(player)==true)
           {
               Console.WriteLine("Hesap eklendi");
           }
           else
           {
               Console.WriteLine("Doğrulama başarısız.Hesap eklenemedi");
           }
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
