namespace Exercises
{
    public class ExerciseCalculator
    {

        public int CalculatorSoma(int a, int b)
        {
           int soma = Sum(a, b);
            return soma;

        }

        public int Calculatorsubtracao(int a, int b)
        {
            int subtraction = Subtraction(a, b);
            return subtraction;

        }

        public int CalculatorDivision(int a, int b)
        {
            int division = Division(a, b);
            return division;

        }

        public int CalculatorMultiplication(int a, int b)
        {
            int multiplication = Multiplication(a, b);
            return multiplication;

        }


        private int Sum(int a, int b)
        {
            return a + b;
        }

        private int Subtraction(int a, int b)
        {
            return a - b;
        }
        private int Division(int a, int b)
        {
            return (a / b);
        }
        private int Multiplication(int a, int b)
        {
            return a * b;
        }

    }
}
