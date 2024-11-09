namespace AreaCalculatorVar2
{
    public static class Calculator
    {
        public static double GetArea(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("radius must be greater than 0");
            }
            return Math.PI * radius * radius;
        }

        public static double GetArea(double a, double b, double c)
        {
            CheckTriangleSides(a, b, c);
            return (a + b + c) / 2;
        }

        public static bool IsRightTriangle(double a, double b, double c)
        {
            CheckTriangleSides(a, b, c);

            double[] sides = { a, b, c };
            Array.Sort(sides);
            return sides[2] * sides[2] - (sides[0] * sides[0] + sides[1] * sides[1]) < 1e-10;
        }

        private static void CheckTriangleSides(double a, double b, double c)
        {
            if (a <= 0 || b < 0)
            {
                throw new ArgumentException("a, b and c must be greater than 0.");
            }
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                throw new ArgumentException("The sum of two sides must be greater than the third side.");
            }
        }
    }
}