namespace DeleteCalculator.Operations
{
    public class Calculations
    {
        public double CalcResult(double numberA, double numberB, string operation)
        {
            double result = 0;

            if (operation == "+")
                result = numberA + numberB;
            if (operation == "/")
                result = numberA / numberB;
            if (operation == "-")
                result = numberA - numberB;
            if (operation == "*")
            {
                result = numberA * numberB;
            }

            return result;

        }
    }





}

