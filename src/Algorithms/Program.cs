using BenchmarkDotNet.Running;

namespace Algorithms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //var summary = BenchmarkRunner.Run<NumberSwapper>();
            var summary = BenchmarkRunner.Run(typeof(Program).Assembly);
        }
    }
}