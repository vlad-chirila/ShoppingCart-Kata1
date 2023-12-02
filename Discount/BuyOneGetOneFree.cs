public class BuyOneGetOneFree : IDiscount
{
    private readonly Product discountedProduct;

    public BuyOneGetOneFree(string productName){
        discountedProduct = new Product(){
             Name = productName,
             Price = 0m
        };
    }

    public void ApplyDiscount(ShoppingCart cart)
    {
        cart.Products.Add(discountedProduct);
    }
}