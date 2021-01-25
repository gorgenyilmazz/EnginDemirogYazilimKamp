using BesinciGunOOPOdev.Abstracts;
using BesinciGunOOPOdev.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BesinciGunOOPOdev.Concrete
{
    class CheckPlayerManager : ICheckPlayerService
    {
        public bool Check(Player player)
        {
            Console.WriteLine("MERNIS Kontrol Simulasyonu Basarili....");
            return true;
        }
    }
}
