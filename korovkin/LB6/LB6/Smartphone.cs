using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB6
{
    class Smartphone
    {
        [Key]
        public  Guid Id { get; set; }
        public string Name { get;  set; }
        public string Screen { get; set; }
        public string Proccessor { get; set; }
        public string Camera { get; set; }
//        public string brand { get; set; }
        public string RAM { get; set; }
     //   public int? BrandId { get; set; }
        public string GetInfo()
        {
            return $"Название: {Name}, \n Экран: { Screen}, \n Процессор: { Proccessor}, \n Камера: { Camera}, \n Оперативная память: { RAM} ";
        }
    }
}
