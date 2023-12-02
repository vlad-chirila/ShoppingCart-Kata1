public interface IShoppingCart
{
    void AddProduct(Product product);
    void ApplyDiscount(IDiscount discount);
    decimal Checkout();
}