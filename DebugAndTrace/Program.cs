using System.Diagnostics;

static class Program
{
	static void Main()
	{
		Debug.WriteLine("Debug says, I am watching!");
		Trace.WriteLine("Trace says, I am watching!");
		Debug.Assert(false, "Debug says, I am watching!");
		Trace.Assert(false, "Trace says, I am watching!");
		Console.ReadKey();
	}
}