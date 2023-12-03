public class CheckoutManager : ICheckoutManager
{
    public decimal Order(ShoppingCart cart)
    {
        Console.WriteLine("Checkout products: ");
        var s = 0m;
        foreach(var product in cart.Products){
             s += product.Price;
             Console.WriteLine(product.Name + " with final price: " + product.Price);
        }
        cart.Products.Clear();

        return s;
    }
}