public class ShoppingCart : IShoppingCart
{
    public List<Product> Products = new List<Product>();

    public void AddProduct(Product product)
    {
        if(product.Price < 0){
            throw new NegativeAmountException("Price product cannot be negative: " + product.Price.ToString());
        }
        Console.WriteLine($"Product { @product.Name } with price { @product.Price } has been added to Cart.");
        Products.Add(product);
    }
}