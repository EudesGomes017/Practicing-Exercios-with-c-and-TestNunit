using Exercises;

namespace Testes
{
    public class ExerciseCalculatorTests
    {


       private ExerciseCalculator _exerciseCalculator;
        [SetUp]
        public void Setup()
        {
            _exerciseCalculator = new ExerciseCalculator();
        }

        [Test]
        public void CalculatorSoma_CalculeterValues_ReturTableValues() 
        {
            int a = 1;
            int b = 1;

            int result = _exerciseCalculator.CalculatorSoma(a, b);

            Assert.AreEqual(2, result);

        }

        [Test]
        public void Calculatorsubtracao_CalculeterValues_ReturTableValues()
        {
            int a = 1;
            int b = 1;

            int result = _exerciseCalculator.Calculatorsubtracao(a, b);

            Assert.AreEqual(0, result);

        }

        [Test]
        public void CalculatorDivision_CalculeterValues_ReturTableValues()
        {
            int a = 1;
            int b = 1;

            int result = _exerciseCalculator.CalculatorDivision(a, b);

            Assert.AreEqual(1, result);

        }

        [Test]
        public void CalculatorMultiplication_CalculeterValues_ReturTableValues()
        {
            int a = 1;
            int b = 1;

            int result = _exerciseCalculator.CalculatorMultiplication(a, b);

            Assert.AreEqual(1, result);

        }
    }
}
