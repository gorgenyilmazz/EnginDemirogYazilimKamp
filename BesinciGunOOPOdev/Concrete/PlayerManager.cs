using BesinciGunOOPOdev.Abstracts;
using BesinciGunOOPOdev.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BesinciGunOOPOdev.Concrete
{
    class PlayerManager : IPlayerService
    {
        ICheckPlayerService _playerCheckManager;
        public PlayerManager(ICheckPlayerService customerCheckService) 
        {
            _playerCheckManager = customerCheckService;
        }
       
        public void Delete(Player player)
        {
            Console.WriteLine("Deleted " + player.FirstName);
        }

        public void Save(Player player)
        {
            if (_playerCheckManager.Check(player))
            {
                Console.WriteLine("Saved to db " + player.FirstName);
            }
            else { throw new Exception("Not a valid person!"); }
        }

        public void Update(Player player)
        {
            Console.WriteLine("Updated " + player.FirstName );
        }
    }
}
