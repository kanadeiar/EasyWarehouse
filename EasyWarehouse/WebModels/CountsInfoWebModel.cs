using System;
using System.ComponentModel.DataAnnotations;

namespace EasyWarehouse.WebModels
{
    public class CountsInfoWebModel
    {
        public int Id { get; set; }
        [Display(Name = "Название")]
        public string Name { get; set; }
        [Display(Name = "Объем товара, м3")]
        public float Volume { get; set; }
        [Display(Name = "Объем процент от максимального")]
        public int VolumePercent { get; set; }
        [Display(Name = "Количество пачек")]
        public int Size { get; set; }
        [Display(Name = "Количество процент от максимального")]
        public int SizePercent { get; set; }
        [Display(Name = "Количество")]
        public int Count { get; set; }
        [Display(Name = "Количество процент от максимального")]
        public int CountPercent { get; set; }
        [Display(Name = "Статус")]
        public string Status { get; set; }
    }
}
