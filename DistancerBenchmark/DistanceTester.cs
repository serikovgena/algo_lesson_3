using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using lesson3;

namespace DistancerBenchmark
{
    [MemoryDiagnoser]
    [RankColumn]
    public class DistanceTester
    {
        private PointClass startPointClassFloat = new() { x = 1, y = 1 };
        private PointClass endPointClassFloat = new() { x = 5, y = -2 };

        private PointStructFloat startPointStructFloat = new() { x = 1, y = 1 };
        private PointStructFloat endPointStructFloat = new() { x = 5, y = -2 };

        private PointStructDouble startPointStructDouble = new() { x = 1, y = 1 };
        private PointStructDouble endPointStructDouble = new() { x = 5, y = -2 };

        private Distancer distancer = new(); 

        [Benchmark]
        public void TestSqrtClassFloat() {
            _ = distancer.MeasureDistance(startPointClassFloat, endPointClassFloat);
        }

        [Benchmark]
        public void TestSqrtStructDouble() {
            _ = distancer.MeasureDistance(startPointStructDouble, endPointStructDouble);
        }

        [Benchmark]
        public void TestSqrtStructFloat() {
            _ = distancer.MeasureDistanceBySin(startPointStructFloat, endPointStructFloat);
        }

        [Benchmark]
        public void TestByArcTanAndSin() {
            _ = distancer.MeasureDistanceBySin(startPointStructFloat, endPointStructFloat);
        }
    }
}
