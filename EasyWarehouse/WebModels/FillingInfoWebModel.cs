using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EasyWarehouse.WebModels
{
    public class FillingInfoWebModel
    {
        public int Id { get; set; }
        [Display(Name = "Место хранения")]
        public string Name { get; set; }
        [Display(Name = "Заполнение %")]
        public int Filling { get; set; }
        [Display(Name = "Свободно мест")]
        public int Free { get; set; }
        [Display(Name = "Занято мест")]
        public int Occupied { get; set; }
        [Display(Name = "Всего мест")]
        public int Size { get; set; }
        [Display(Name = "Статус")]
        public string Status { get; set; }
    }
}
