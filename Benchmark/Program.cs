using BenchmarkDotNet.Running;

namespace Benchmark
{
    class Program
    {
        static void Main(string[] args)
        {

            var summary = BenchmarkRunner.Run<Md5VsSha256>();
        }
    }
}


// dotnet build -c Release