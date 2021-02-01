using System;
using System.Collections.Generic;
using System.Text;

namespace MyHomeworkGame
{
    class UserValidationManager : IUserValidateService
    {
        public bool Validate(Player player)
        {
            if(player.BirthYear == 2002 && player.FirstName == "SAMİ" && player.LastName == "KÖSE" && player.Tc == 12345678900)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
