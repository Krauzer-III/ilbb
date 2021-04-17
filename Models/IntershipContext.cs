using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ATOM.Models
{
    public class IntershipContext : DbContext
    {
        public IntershipContext() : base("IntershipConnection") { }

        public DbSet<Intership> Interships { get; set; }
        public DbSet<DictStateIntership> DictStateInterships { get; set; }

    }

    public class DbIntershipInitializer : CreateDatabaseIfNotExists<IntershipContext>
    {
        protected override void Seed(IntershipContext context)
        {
            var CSS_1 = new DictStateIntership { StateIntershipName = "Активна", CSSClass = "badge badge-pill badge-success" };
            var CSS_2 = new DictStateIntership { StateIntershipName = "Черновик", CSSClass = "badge badge-pill badge-warning" };
            var CSS_3 = new DictStateIntership { StateIntershipName = "В архиве", CSSClass = "badge badge-pill badge-secondary" };
            context.DictStateInterships.Add(CSS_1);
            context.DictStateInterships.Add(CSS_2);
            context.DictStateInterships.Add(CSS_3);



            context.SaveChanges();
        }
    }
}