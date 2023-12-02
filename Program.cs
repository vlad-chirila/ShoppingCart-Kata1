var cart = new ShoppingCart();

cart.AddProduct(new Product { Name = "C# in Depth", Price = 40.00m });
cart.AddProduct(new Product { Name = "The CleanCoder", Price = 25.00m });
cart.ApplyDiscount(new PercentageDiscount(0.2m)); // Applying 20% discount
cart.ApplyDiscount(new BuyOneGetOneFree("The CleanCoder"));

var total = cart.Checkout();

Console.WriteLine(total.ToString());