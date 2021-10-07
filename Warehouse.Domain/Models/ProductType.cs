namespace Warehouse.Domain.Models
{
    /// <summary> Тип товара </summary>
    public class ProductType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Volume { get; set; }
        public int Count { get; set; }
    }
}
