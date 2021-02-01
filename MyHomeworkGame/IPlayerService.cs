using System;
using System.Collections.Generic;
using System.Text;

namespace MyHomeworkGame
{
    interface IPlayerService
    {
        void Add(Player player);
        void Delete(Player player);
        void InformationList(Player player);
        void Update(Player player);
    }
}
