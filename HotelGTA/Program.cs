using System;

namespace HotelGTA
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vetor Estudante instanciado
            Estudante[] vect = new Estudante[10];
            //Input de quantos quartos serao ocupados
            Console.WriteLine("Quantos quartos serão alugados? ");

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Hospede #{i}");
                //Input nome
                Console.WriteLine("Nome");
                string nome = Console.ReadLine();
                //Input Email
                Console.WriteLine("Email");
                string email = Console.ReadLine();
                //Input Quarto e determinando quantidade de quartos
                Console.WriteLine("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vect[quarto] = new Estudante(nome, email);
            }
            //Output quantidade de quartos
            Console.WriteLine();
            Console.WriteLine("Quartos ocupados: ");
            for (int i = 0; i < 10; i++)
            {
                //Excluindo quartos vazios
                if (vect[i] != null)
                {
                    //Printa todos os dados em ordem numerica
                    Console.WriteLine(i + "  " + vect[i]);
                }
            }
        }
    }
}
