using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AIAMVC.Models
{
    public class MusicDbContext : DbContext
    {
        public DbSet<Song> Songs { get; set; }

        public System.Data.Entity.DbSet<AIAMVC.Models.Genre> Genres { get; set; }
    }
}