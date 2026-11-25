
namespace Catalog.Products.Models
{
    public class Product : Entity<Guid>
    {
        public string Name { get; private set; } = default;
        public List<string> Category { get; private set; } = new();
        public string Description { get; private set; } = default;
        public string ImageFileName { get; private set; } = default;
        public decimal Price { get; private set; } = default;

        public static Product Create(
            Guid id,string name, 
            List<string> category, 
            string description, string imageFileName, decimal price
            )
        {
            ArgumentException.ThrowIfNullOrEmpty(name, nameof(name));
            ArgumentOutOfRangeException.ThrowIfNegative(price, nameof(price));

            var product = new Product
            {
                Id = id,
                Name = name,
                Category = category,
                Description = description,
                ImageFileName = imageFileName,
                Price = price
            };
            return product;
        }

        public void Update(
            string name,
            List<string> category,
            string description, string imageFileName, decimal price
            )
        {
            ArgumentException.ThrowIfNullOrEmpty(name, nameof(name));
            ArgumentOutOfRangeException.ThrowIfNegative(price, nameof(price));
            Name = name;
            Category = category;
            Description = description;
            ImageFileName = imageFileName;
            Price = price;
        }

    }
}
