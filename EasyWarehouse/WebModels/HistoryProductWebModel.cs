using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyWarehouse.WebModels
{
    public class HistoryProductWebModel
    {
        /// <summary> Дата поступления товаров на склад </summary>
        public DateTime DateTime { get; set; }
        /// <summary> Товары за эту дату </summary>
        public IEnumerable<ProductWebModel> Products { get; set; }
    }
}
