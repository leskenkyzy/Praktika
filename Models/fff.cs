using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Praktika.Models
{
    public class fff : DbContext
        {
        public fff()
            : base("name=fff")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<DbContext>());
        }
        public virtual DbSet<Dostavka> Dostavkas { get; set; }
        public virtual DbSet<Status> Statuses { get; set; }
    }
}
