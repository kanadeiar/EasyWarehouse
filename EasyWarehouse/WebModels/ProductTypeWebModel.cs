using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EasyWarehouse.WebModels
{
    public class ProductTypeWebModel
    {
        public int Id { get; set; }
        [Display(Name = "Название")]
        public string Name { get; set; }
        [Display(Name = "Объем, м3")]
        public float Volume { get; set; }
        [Display(Name = "Кол-во, шт.")]
        public int Count { get; set; }
    }
}
