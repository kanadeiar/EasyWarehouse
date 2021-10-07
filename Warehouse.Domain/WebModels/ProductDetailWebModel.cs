using System;
using System.ComponentModel.DataAnnotations;

namespace Warehouse.Domain.WebModels
{
    public class ProductDetailWebModel
    {
        public int Id { get; set; }
        [Display(Name = "Название товара")]
        public string Name { get; set; }
        /// <summary> Идентификатор места размещения товара </summary>
        public int PlaceId { get; set; }
        [Display(Name = "Место размещения товара")]
        public string PlaceName { get; set; }
        [Display(Name = "Дата и время поступления товара")]
        public DateTime DateTime { get; set; }
        [Display(Name = "Объем товара, м3")]
        public float Volume { get; set; }
        [Display(Name = "Количество в пачке, шт.")]
        public int Count { get; set; }
    }
}
