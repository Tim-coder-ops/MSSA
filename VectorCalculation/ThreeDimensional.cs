using System;
using System.Collections.Generic;
using System.Text;

namespace VectorCalculation
{
    class threeDimensional
    {
        static Tuple<int, int, int>[] vectors = new Tuple<int, int, int>[1000];

        public static void populateVectors()
        {
            Random random = new Random();

            for (int i = 0; i < vectors.Length; i++)
            {
                int x = random.Next(1, 1000);
                int y = random.Next(1, 1000);
                int z = random.Next(1, 1000);
                Tuple<int, int, int> vect = new Tuple<int, int, int>(x, y, z);

                vectors[i] = vect;
            }

        }

        public static double CalcDistance(Tuple<int, int, int> pointA, Tuple<int, int, int> pointB)
        {
            double distance = Math.Sqrt(Math.Pow((pointA.Item1 - pointB.Item1), 2) + Math.Pow((pointA.Item2 - pointB.Item2), 2) + Math.Pow((pointA.Item3 - pointB.Item3), 2));

            return distance;
        }

        public static void GetShortestDist3()
        {
            int point1 = 0;
            int point2 = 0;
            double distance = CalcDistance(vectors[0], vectors[1]);

            for (int i = 0; i < vectors.Length; i++)
            {
                for (int j = 0; j < vectors.Length; j++)
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

            Console.WriteLine($"The shortest distance is point {point1} ({vectors[point1].Item1}, {vectors[point1].Item2}, {vectors[point1].Item3}) " +
                $"and " +
                $"point {point2} ({vectors[point2].Item1}, {vectors[point2].Item2}, {vectors[point2].Item3})" +
                $" with the distance of {distance} ");
        }
    }


}
