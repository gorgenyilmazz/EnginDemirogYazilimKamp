using BesinciGunOOPOdev.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BesinciGunOOPOdev.Abstracts
{
    interface IPlayerService
    {
        void Save(Player player);
        void Update(Player player);
        void Delete(Player player);
    }
}
