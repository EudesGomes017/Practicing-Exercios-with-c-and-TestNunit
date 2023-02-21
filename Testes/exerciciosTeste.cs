using Exercises;

namespace Testes
{
    public class exerciciosTests
    {
        Exercicios exercicios;

        [SetUp]
        public void Setup()
        {
            exercicios = new Exercicios();
        }


        //[Test]
        //public void DoublePrecisionCalculates_CalculeValues()
        //{
        //    double a = 3;
        //    double b = 2;   
        //    double c = 3;

        //    double result = exercicios.DoublePrecisionCalculates(a, b, c);

        //    Assert.AreEqual(4.5, result);
        //}
    }
}