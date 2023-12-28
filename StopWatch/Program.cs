internal partial class Program
{

    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        StopWatch stopwatch = new StopWatch();
        stopwatch.Start();
        Thread.Sleep(3000);
        stopwatch.Stop();
        Console.WriteLine($"Time: {stopwatch.Duration()}");

        stopwatch.Start();
        Thread.Sleep(1000);
        stopwatch.Stop();
        Console.WriteLine($"Time: {stopwatch.Duration()}");

    }
}