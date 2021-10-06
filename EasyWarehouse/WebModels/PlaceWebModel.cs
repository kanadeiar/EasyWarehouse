using System.ComponentModel.DataAnnotations;

namespace EasyWarehouse.WebModels
{
    public class PlaceWebModel
    {
        public int Id { get; set; }
        [Display(Name = "Название")]
        public string Name { get; set; }
        [Display(Name = "Количество хранимого товара, шт.")]
        public int CountProducts { get; set; }
        [Display(Name = "Вместимость, шт.")]
        public int Size { get; set; }
        [Display(Name = "Состояние")]
        public string Status { get; set; }
    }
}
