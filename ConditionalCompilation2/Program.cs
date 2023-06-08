#define DEBUG
class Program {
    static void Main() {
        #if (DEBUG)
        Console.WriteLine("Mode debug diaktifkan.");
        #endif

        Console.WriteLine("Program berjalan...");
    }
}
