public class DiscountManager : IDiscountManager
{
    public void ApplyDiscount(IDiscount discount, ShoppingCart cart){
        discount.ApplyDiscount(cart);
    }
}