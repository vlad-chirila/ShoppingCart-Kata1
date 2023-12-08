//Global Exception Handler
AppDomain.CurrentDomain.UnhandledException += GlobalExceptionHandler.HandleException;
//

// Client
var cart = new ShoppingCart();
var discountManager = new DiscountManager();
var checkoutManager = new CheckoutManager();

cart.AddProduct(new Product { Name = "C# in Depth", Price = 40.00m });
cart.AddProduct(new Product { Name = "The CleanCoder", Price = 25.00m });

discountManager.ApplyDiscount(new PercentageDiscount(0.2m), cart);
discountManager.ApplyDiscount(new BuyOneGetOneFree("The CleanCoder"), cart);

var total = checkoutManager.Order(cart);

Console.WriteLine(total.ToString());
