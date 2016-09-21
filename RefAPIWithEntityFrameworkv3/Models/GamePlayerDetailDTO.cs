using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RefAPIWithEntityFrameworkv3.Models
{
    public class GamePlayerDetailDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsCaptain { get; set; }
        public bool IsStartingSubstitute { get; set; }
        public string TeamName { get; set; }
    }
}