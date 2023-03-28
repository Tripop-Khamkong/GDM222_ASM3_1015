class Program {
    static void Main(string[] args) {
        double x1, y1, x2, y2, r1, r2;

        Console.WriteLine("Input center of circle C1");
        x1 = double.Parse(Console.ReadLine());
        y1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Input center of circle C2");
        x2 = double.Parse(Console.ReadLine());
        y2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Input radius of circle C1");
        r1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Input radius of circle C2");
        r2 = double.Parse(Console.ReadLine());

        double distance = Math.Sqrt(Math.Pow(x2 - x1, 2f) + Math.Pow(y2 - y1, 2f));

        if (distance <= r1 + r2) {
            double a = (r1 * r1 - r2 * r2 + distance * distance)/(2*distance);
            double h = Math.Sqrt(r1 * r1 - a * a);
            
            //P2
            double x3 = x1 + a * (x2 - x1) / distance;
            double y3 = y1 + a * (y2 - y1) / distance;
            //intersectionPoint1
            double x4 = x3 - h * (y2 - y1) / distance;
            double y4 = y3 + h * (x2 - x1) / distance;
            //intersectionPoint2
            double x5 = x3 + h * (y2 - y1) / distance;
            double y5 = y3 - h * (x2 - x1) / distance;

            if(distance == r1 + r2)
            {
                Console.WriteLine(x4);
                Console.WriteLine(y4);
            }
            else
            {
                Console.WriteLine(x4);
                Console.WriteLine(y4);
                Console.WriteLine(x5);
                Console.WriteLine(y5);
            }

        }
    }
}