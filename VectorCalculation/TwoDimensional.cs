using System;
using System.Collections.Generic;
using System.Text;

namespace VectorCalculation
{
    class TwoDimensional
    {
        static Tuple<int, int>[] vectors = new Tuple<int, int>[100];

        public static void populateVectors()
        {
            Random random = new Random();

            for(int i = 0; i < vectors.Length; i++)
            {
                int x = random.Next(1,100);
                int y = random.Next(1, 100);
                Tuple<int, int> vect = new Tuple<int,int>(x,y);

                vectors[i] = vect;
            }

        }

        public static double CalcDistance(Tuple<int, int> pointA, Tuple<int,int> pointB)
        {
            double distance = Math.Sqrt(Math.Pow((pointA.Item1 - pointB.Item1), 2) + Math.Pow((pointA.Item2 - pointB.Item2), 2));

            return distance;
        }

        public static void GetShortestDist2()
        {
            int point1 = 0;
            int point2 = 0;
            double distance = CalcDistance(vectors[0], vectors[1]);

            for(int i = 0; i < vectors.Length; i++)
            {
                for(int j = 0; j < vectors.Length; j++)
                {
                    if (i != j)
                    {
                        double newDist = CalcDistance(vectors[i], vectors[j]);
                        if (newDist < distance)
                        {
                            point1 = i;
                            point2 = j;
                            distance = newDist;
                        }
                    }
                }
            }

            Console.WriteLine($"The shortest distance between 2 points is between point {vectors[point1].Item1}, {vectors[point1].Item2} and " +
                $"point {vectors[point2].Item1}, {vectors[point2].Item2}");
        }
    }
}
