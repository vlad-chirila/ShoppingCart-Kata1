namespace ShoppingCart_Kata1_UnitTest;

public class ExceptionTest
{
    [Fact]
    public void GivenCartWithNegativeAmountOnProductShouldThrowException()
    {
        //Arrange
        var shoppingCart = new ShoppingCart();
        var product = new Product()
        {
            Name = "Test Product",
            Price = -99
        };

        //Act&Assert
        Assert.Throws<NegativeAmountException>(() => shoppingCart.AddProduct(product));
    }
}