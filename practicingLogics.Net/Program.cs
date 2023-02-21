using Exercises;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Exercicios exerciciosOne = new Exercicios();
            ArrayExercise arrayExercise = new ArrayExercise();
            
          
            int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());

            //int c = Convert.ToInt32(Console.ReadLine());
            //int d = Convert.ToInt32(Console.ReadLine());

            //double result = exerciciosOne.DoublePrecisionCalculates(a, b, c);

            List<int> list = arrayExercise.Array(a);

            Console.WriteLine(list);
        }
    }
}