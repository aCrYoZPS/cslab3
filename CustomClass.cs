namespace CustomClass
{
    public class MyClass
    {
        public static double ProcessNumber(double a)
        {
            if (a - (int)a > 0.00000001)
            {
                return a - 3;
            }
            if (a % 2 == 0)
            {
                return a / 2;
            }
            else
            {
                return a - 3;
            }
        }
    }
}
