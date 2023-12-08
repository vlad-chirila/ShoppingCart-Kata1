public class NegativeAmountException : Exception{

     public NegativeAmountException(){ }

    public NegativeAmountException(string message): base(message){}
}