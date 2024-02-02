namespace EntityFMWK
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Count { get; set; }
        public DateTime Date { get; set; }
        public double Price { get; set; }
    }
}
