public class ShoppingCart : IShoppingCart
{
    public List<Product> Products = new List<Product>();

    public void AddProduct(Product product)
    {
        Console.WriteLine($"Product { @product.Name } with price { @product.Price } has been added to Cart.");
        Products.Add(product);
    }

    public void ApplyDiscount(IDiscount discount)
    {
        Console.WriteLine("Discount has been added: "+ discount.GetType());
        discount.ApplyDiscount(this);
    }

    public decimal Checkout()
    {
        Console.WriteLine("Checkout products: ");
        var s = 0m;
        foreach(var product in Products){
             s+=product.Price;
             Console.WriteLine(product.Name + " with final price: " + product.Price);
        }
        Products.Clear();

        return s;
    }
}