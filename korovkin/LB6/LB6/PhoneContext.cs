using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace LB6
{
    class PhoneContext:DbContext
    {
        public PhoneContext() : base("testt") { }
        public DbSet<Smartphone> Smartphones { get; set; }
     //   public DbSet<Brand> Brands { get; set; }
    }
}
