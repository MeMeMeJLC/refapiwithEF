using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RefAPIWithEntityFrameworkv3.Models
{
    public class Team
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public ICollection<GamePlayer> GamePlayers { get; set; }
    }
}