public class ShoppingCart : IShoppingCart
{
    public List<Product> Products = new List<Product>();

    public void AddProduct(Product product)
    {
        Console.WriteLine($"Product { @product.Name } with price { @product.Price } has been added to Cart.");
        Products.Add(product);
    }
}