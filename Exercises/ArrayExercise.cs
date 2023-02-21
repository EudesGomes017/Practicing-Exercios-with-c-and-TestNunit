
namespace Exercises
{
    public class ArrayExercise
    {
        /*A dona de um pensionato possui dez quartos para alugar para estudantes,
      sendo esses quartos identificados pelos números 0 a 9.

      Fazer um programa que inicie com todos os dez quartos vazios, e depois
      leia uma quantidade N representando o número de estudantes que vão
      alugar quartos (N pode ser de 1 a 10).
        
      Em seguida, registre o aluguel dos
      N estudantes. 
        
      Para cada registro de aluguel, informar o nome e email do
      estudante, bem como qual dos quartos ele escolheu (de 0 a 9). Suponha
      que seja escolhido um quarto vago. Ao final, seu programa deve imprimir
      um relatório de todas ocupações do pensionato, por ordem de quarto,
      conforme exemplo.
        */

        public List<int> Array(int n)
        {
            List<int> rent = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            
            for (int i = 0; i < n; i++)
            {

                
               Console.WriteLine("Rent #" + i + ":");
                Console.WriteLine("Name: ");
            

                string name = Console.ReadLine();
                Console.WriteLine("Email: ");

                string email = Console.ReadLine();
                Console.WriteLine("Room: ");
                int room = Convert.ToInt32(Console.ReadLine());
                //rent[room] = new Teste(name, email);

            }

            for (int i = 0; i < rent.Count; i++)
            {
                if (rent[i] != null)
                {
                    Console.WriteLine(i + ": " + rent[i]);
                }
            }

            return rent;
        }
    }
}
