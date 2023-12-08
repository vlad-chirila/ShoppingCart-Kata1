public class ProductMissingException : Exception{

     public ProductMissingException(){ }

    public ProductMissingException(string message): base(message){}
}