using System.Security.Cryptography.X509Certificates;

namespace Exercises
{
    public class Exercicios
    {

        /*Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números*/
        public int Sum_Values(int a, int b)
        {
            int sum = a + b;

            return sum;
        }

        //Rais quadrada
        public double SquareRoot(int a)
        {
            double sum = Math.Sqrt(a);

            return sum;
        }

        /*Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
       casas decimais conforme exemplos*/
        public double RadiusOfaCircle(double R, double A)
        {
            double pi = Math.PI;

            double result = pi * R * R;

            return result;
        }

        /*  Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto
        de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D)*/
        public double ReadFourIntegerValues(double a, double b, double c, double d)
        {
            double sum = (a * b) - (c * d);

            return sum;
        }


        /*  Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por
       hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas
       decimais*/
        public double NumberOfAnEmployee(double horasT, double salary)
        {

            double result = horasT * salary;

            double resultFin = salary + result;

            return resultFin;
        }

        /*Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
        código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.*/
        public double CalculatePartValues(double quantOne, double quantTwo, double priceOne, double priceTwo)
        {
            double total = priceOne * quantOne + priceTwo * quantTwo;

            return total;
        }

        /* Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e
       mostre:
       a) a área do triângulo retângulo que tem A por base e C por altura. // formúla =  A = b.h / 2
       b) a área do círculo de raio C. (pi = 3.14159) // FORMULA A = π * r²
       c) a área do trapézio que tem A e B por bases e C por altura.
       d) a área do quadrado que tem lado B.
       e) a área do retângulo que tem lados A e B */
        public double DoublePrecisionCalculates(double A, double B, double C)
        {
            double triangulo =  A * C / 2.0; 
            
            double circulo = 3.14159 * C * C;

            double trapezio = (A + B) / 2.0 * C;

            double quadrado = B * B;

            double retangulo = A * B;

            return triangulo;
        }

    }
}
