using System.ComponentModel.DataAnnotations;

public class GlobalExceptionHandler{

public static void HandleException(object sender, UnhandledExceptionEventArgs args){
    Exception e = (Exception) args.ExceptionObject;

    if(e is NegativeAmountException){
        Console.WriteLine("Amount is negative. NegativeAmountException was thrown.");
    }

    if(e is ProductMissingException){
        Console.WriteLine("Product does not exists.");
    }

    if(e is ValidationException){
        Console.WriteLine("Validation exception was thrown");
    }
}
}
