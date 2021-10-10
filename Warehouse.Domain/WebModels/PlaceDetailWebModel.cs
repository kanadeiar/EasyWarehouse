using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Warehouse.Domain.WebModels
{
    public class PlaceDetailWebModel
    {
        public int Id { get; set; }
        [Display(Name = "Название места хранения товаров")]
        public string Name { get; set; }
        [Display(Name = "Количество хранимого товара, пачек.")]
        public int ProductsCount { get; set; }
        [Display(Name = "Вместимость места хранения, пачек.")]
        public int Size { get; set; }
        [Display(Name = "Состояние места хранения")]
        public string Status { get; set; }
        [Display(Name = "Объем занимаемого места товарами, м3")]
        public float ProductsVolume { get; set; }
        [Display(Name = "Количество товара суммированное, штук")]
        public float ProductsSum { get; set; }
        [Display(Name = "Товары на этом месте хранения")]
        public IEnumerable<ProductWebModel> Products { get; set; }
    }
}
