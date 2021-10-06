using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EasyWarehouse.WebModels
{
    public class ProductWebModel
    {
        public int Id { get; set; }
        [Display(Name = "Название")]
        public string Name { get; set; }
        [Display(Name = "Место")]
        public string PlaceName { get; set; }
        [Display(Name = "Дата и время")]
        public DateTime DateTime { get; set; }
        [Display(Name = "Объем товара, м3")]
        public float Volume { get; set; }
        [Display(Name = "Количество")]
        public int Count { get; set; }
    }
}
