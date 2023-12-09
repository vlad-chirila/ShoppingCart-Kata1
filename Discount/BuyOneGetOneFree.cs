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
        if(!cart.Products.Any(p=>p.Name == discountedProduct.Name)){
            throw new ProductMissingException("Cannot apply discount to product name: " + discountedProduct.Name);
        }
        cart.Products.Add(discountedProduct);
    }

    public void RemoveDiscount(){
        throw new NotImplementedException();
    }

    public void DoubleDiscount(ShoppingCart cart){
        ApplyDiscount(cart);
        ApplyDiscount(cart);
    }
}