namespace Services
{
    public class CustMath
    {
        public static void CalculateExpression(double z)
        {
            int variant = 0;
            double x;
            if (z < 0)
            {
                x = z;
                variant = 1;
            }
            else
            {
                x = Math.Sin(z);
                variant = 2;
            }
            double y =
                2 * Math.Pow(Math.Sin(x), 2) / 3 - 3 * Math.Pow(Math.Cos(x), 2) / 4;
            System.Console.WriteLine(
                $"Результат вычисления выражения варианта 6 по ветке {variant} для значения z = {z} равен {y}");
        }
    }
}

// variant 6
