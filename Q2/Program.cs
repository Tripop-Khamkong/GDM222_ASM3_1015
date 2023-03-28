using System;
using System.Collections.Generic;
using System.Drawing;
    class Program
    {
        static void Main(string[] args)
        {
            List<PointF> polygon = new List<PointF>();

            while (true)
            {
                Console.Write("Enter x and y (separated by a space): ");
                string[] input = Console.ReadLine().Split();
                float x = float.Parse(input[0]);
                float y = float.Parse(input[1]);

                if (x == 0 && y == 0)
                {
                    break;
                }

                polygon.Add(new PointF(x, y));
            }

            Console.Write("Enter the point to be tested (x and y separated by a space): ");
            string[] pointInput = Console.ReadLine().Split();
            float pointX = float.Parse(pointInput[0]);
            float pointY = float.Parse(pointInput[1]);
            PointF point = new PointF(pointX, pointY);

            bool isInside = false;
            int j = polygon.Count - 1;

            for (int i = 0; i < polygon.Count; i++)
            {
                if ((polygon[i].Y < point.Y && polygon[j].Y >= point.Y || polygon[j].Y < point.Y && polygon[i].Y >= point.Y) &&
                    (polygon[i].X + (point.Y - polygon[i].Y) / (polygon[j].Y - polygon[i].Y) * (polygon[j].X - polygon[i].X) < point.X))
                {
                    isInside = !isInside;
                }

                j = i;
            }

            // Output the result
            if (isInside)
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Outside");
            }
        }
    }
