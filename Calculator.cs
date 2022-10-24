class Calculator
{
    public static double DoOperation(double num1, double num2, string op)
    {
        double result = double.NaN;
        switch (op)
        {
            case "a":
                result = num1 + num2;
                break;
            case "s":
                result = num1 - num2;
                break;
            case "m":
                result = num1 * num2;
                break;
            case "d":

                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                break;
            case "p":
                result = Math.Pow(num1, num2);
                break;
             
            case "ab":
                result = Math.Abs(num1);
                break;

            case "cos":

                result = Math.Cos(num1);
                break;

            case "sin":

                result = Math.Sin(num1);
                break;
            
            case "sqr":
                result = Math.Sqrt(num1);
                break;

            default:
                break;
        }
        return result;
    }
}
