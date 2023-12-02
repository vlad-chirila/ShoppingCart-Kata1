# ShoppingCart-Kata1

1. The Shopping Cart Kata
Objective:
Design a simple shopping cart using OOP principles that can handle the addition of different types of products and apply various discounts and tax rules.
Requirements:
Products should have at least a name and a price.
The shopping cart should be able to add products and return the current total.
Implement a way to handle different types of discounts (e.g., buy one get one free, 20% off).
Apply state-based tax calculations when checking out.
Consider using SOLID principles to design the classes.
Make sure to write code that is easily extensible for new product types and discount rules.
Sample Interface:
-------------------------------------------
public interface IShoppingCart
{
void AddProduct(Product product);
void ApplyDiscount(IDiscount discount);
decimal Checkout();
}
public class Product
{
public string Name { get; set; }
public decimal Price { get; set; }
// Consider adding more properties for discounts, etc.
}
public interface IDiscount
{
void ApplyDiscount(ShoppingCart cart);
}
// Example Usage:
var cart = new ShoppingCart();
cart.AddProduct(new Product { Name = "C# in Depth", Price = 40.00m });
cart.ApplyDiscount(new PercentageDiscount(0.2m)); // Applying 20% discount
var total = cart.Checkout();
-------------------------------------------------
