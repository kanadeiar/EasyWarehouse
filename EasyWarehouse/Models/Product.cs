namespace EasyWarehouse.Models
{
    /// <summary> Товар </summary>
    public class Product
    {
        public int Id { get; set; }
        public int ProductTypeId { get; set; }
        public int PlaceId { get; set; }
    }
}
