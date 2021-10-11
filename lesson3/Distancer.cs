using System;

namespace lesson3
{
    public class Distancer
    {
        public float MeasureDistance(PointClass startPoint, PointClass endPoint) {
            float cathetA = Math.Abs(endPoint.x - startPoint.x);
            float cathetB = Math.Abs(endPoint.y - startPoint.y);

            float result = (float)Math.Sqrt((double)(Math.Pow(cathetA, 2) + Math.Pow(cathetB, 2)));
            return result;
        }

        public float MeasureDistance(PointStructFloat startPoint, PointStructFloat endPoint) {
            float cathetA = Math.Abs(endPoint.x - startPoint.x);
            float cathetB = Math.Abs(endPoint.y - startPoint.y);

            float result = (float)Math.Sqrt((double)(Math.Pow(cathetA, 2) + Math.Pow(cathetB, 2)));
            return result;
        }

        public double MeasureDistance(PointStructDouble startPoint, PointStructDouble endPoint) {
            double cathetA = Math.Abs(endPoint.x - startPoint.x);
            double cathetB = Math.Abs(endPoint.y - startPoint.y);

            double result = Math.Sqrt(Math.Pow(cathetA, 2) + Math.Pow(cathetB, 2));
            return result;
        }

        public float MeasureDistanceBySin(PointStructFloat startPoint, PointStructFloat endPoint) {
            float cathetA = Math.Abs(endPoint.x - startPoint.x);
            float cathetB = Math.Abs(endPoint.y - startPoint.y);

            if (cathetA > 0) {
               return cathetB / ((float)Math.Sin(Math.Atan(cathetB / cathetA)));
            }
            return 0;
        }
    }
}
