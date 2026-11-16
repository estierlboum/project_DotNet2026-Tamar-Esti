using DalApi;
using DO;
namespace Dal
{
    internal class ProductImplementation : IProduct
    {
        public int Create(Product item)
        {
            int newId = DataSource.Config.NextProductId;

            Product newProduct = item with { Id = newId };

            DataSource.Products.Add(newProduct);

            return newId;
        }

        public void Delete(int id)
        {
            Product? productToDelete = Read(id);
            if (productToDelete == null)
            {
                throw new KeyNotFoundException($"Product with ID {id} not found.");
            }
            DataSource.Products.Remove(productToDelete);
        }

        public Product? Read(int id)
        {
            foreach (Product product in DataSource.Products)
            {
                if (product.Id == id)
                {
                    return product;
                }

            }
            return null;
        }

        public List<Product> ReadAll()
        {
            return new List<Product>(DataSource.Products);
        }

        public void Update(Product item)
        {
            Product? oldProduct = Read(item.Id);

            if (oldProduct == null)
            {
                throw new KeyNotFoundException($"Product with ID {item.Id} not found.");
            }

            DataSource.Products.Remove(oldProduct);
            DataSource.Products.Add(item);
        }
    }
}
