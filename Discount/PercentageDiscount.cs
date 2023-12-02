public class PercentageDiscount : IDiscount
{
    private decimal amountDiscounted = 0m;

    public PercentageDiscount(decimal discount){
        amountDiscounted = discount;
    }

    public void ApplyDiscount(ShoppingCart cart)
    {
       foreach(var product in cart.Products){
            var discount = product.Price * amountDiscounted;
            product.Price -= discount;
       }
    }
}