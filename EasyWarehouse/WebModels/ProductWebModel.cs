using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyWarehouse.WebModels
{
    public class ProductWebModel
    {
        public string Name { get; set; }
        public string PlaceName { get; set; }
        public DateTime DateTime { get; set; }
        public int Count { get; set; }
    }
}
