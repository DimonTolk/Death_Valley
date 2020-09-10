using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DeathValley.Models
{
    public class DataBaseContext: DbContext
    {
        public DbSet<Point> Points { get; set; }
        public DbSet<UserData> UserDatas { get; set; }
    }
}