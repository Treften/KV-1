using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB6
{
    class Brand
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Smartphone> Smartphones { get; set; }
        public Brand()
        {
            Smartphones = new List<Smartphone>();
        }
        public Brand(int newid,string newName)
        {
            Smartphones = new List<Smartphone>();
            Id = newid;
            Name = newName;
        }
    }
}
