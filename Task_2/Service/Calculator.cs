namespace Task_2.Service
{
    public static class Calculator
    {
        public static double Add(double value1, double value2)
        {
            return value1 + value2;
        }
        public static double Mul(double value1, double value2)
        {
            return value1 * value2;
        }
        public static double Div(double value1, double value2)
        {
            if (value2 != 0)
            {
                return value1 / value2;
            }

            return 0;
        }

        public static double Sub(double value1, double value2)
        {
            return value1 - value2;
        }
    }
}
