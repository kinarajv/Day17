using System.Diagnostics.Contracts;

class Program
{
    static int Divide(int x, int y)
    {
        Contract.Requires(y != 0);
        Contract.Ensures(Contract.Result<int>() >= 0);
        
        // Assume that x is positive (even though we can't be sure)
        Contract.Assume(x > 0);
        
        int result = x / y;
        
        // Assert that the result is positive (even though we can't be sure)
        // This is to demonstrate the difference between Assume and Assert
        Contract.Assert(result > 0);
        
        return result;
    }
    
    static void Main(string[] args)
    {
        // Test the Divide method with different inputs
        Console.WriteLine(Divide(10, 5)); // should print 2
        Console.WriteLine(Divide(10, 0)); // should throw an exception due to Requires
        Console.WriteLine(Divide(-10, 5)); // should throw an exception due to Assume and Assert
    }
}
