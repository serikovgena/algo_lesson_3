using System;
using System.Diagnostics;

namespace lesson3
{
    class Program
    {
        static void Main() {
          TestDistancer();
        }

        static void TestDistancer() {
          PointClass startPointClassFloat = new() { x = 1, y = 1 };
          PointClass endPointClassFloat = new() { x = 5, y = -2 };
          
          PointStructFloat startPointStructFloat = new() { x = 1, y = 1 };
          PointStructFloat endPointStructFloat = new() { x = 5, y = -2 };
          
          PointStructDouble startPointStructDouble = new() { x = 1, y = 1 };
          PointStructDouble endPointStructDouble = new() { x = 5, y = -2 };
          
          Distancer distancer = new();
          
          using (new TimeLogger())
          {
              _ = distancer.MeasureDistance(startPointClassFloat, endPointClassFloat);
          }
          using (new TimeLogger())
          {
              _ = distancer.MeasureDistance(startPointStructDouble, endPointStructDouble);
          }
          using (new TimeLogger())
          {
              _ = distancer.MeasureDistanceBySin(startPointStructFloat, endPointStructFloat);
          }
          using (new TimeLogger())
          {
              _ = distancer.MeasureDistanceBySin(startPointStructFloat, endPointStructFloat);
          }
       }
    }

    class TimeLogger : IDisposable
    {
        Stopwatch timer;
        public TimeLogger() {
            timer = new Stopwatch();
            timer.Start();
        }

        public void Dispose() {
            timer.Stop();
            Console.WriteLine($"{timer.Elapsed.TotalMilliseconds} ms");
        }
    }
}
