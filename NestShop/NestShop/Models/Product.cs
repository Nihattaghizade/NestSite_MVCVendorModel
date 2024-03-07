namespace NestShop.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public double? Rating { get; set; }
        public decimal SellPrice { get; set; }
        public decimal? DiscountPrice { get; set; }

    }
}
