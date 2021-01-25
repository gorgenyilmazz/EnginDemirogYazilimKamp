using System;
using System.Collections.Generic;
using System.Text;

namespace BesinciGunOOPOdev.Entities
{
    class Player
    {
        public int PlayerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalityId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<Game> MyGames { get; set; }

    }
}
