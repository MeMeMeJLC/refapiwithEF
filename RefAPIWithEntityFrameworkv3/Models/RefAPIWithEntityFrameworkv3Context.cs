using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RefAPIWithEntityFrameworkv3.Models
{
    public class RefAPIWithEntityFrameworkv3Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public RefAPIWithEntityFrameworkv3Context() : base("name=RefAPIWithEntityFrameworkv3Context")
        {
        }

        public System.Data.Entity.DbSet<RefAPIWithEntityFrameworkv3.Models.Team> Teams { get; set; }

        public System.Data.Entity.DbSet<RefAPIWithEntityFrameworkv3.Models.GamePlayer> GamePlayers { get; set; }
    }
}
