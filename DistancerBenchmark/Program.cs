using BenchmarkDotNet.Running;

namespace DistancerBenchmark
{
    class Program
    {
        static void Main(string[] args) {
            BenchmarkRunner.Run<DistanceTester>();
        }
    }
}
