using System;

namespace Diamante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero,
            espacos,
            asteriscos;

            Console.WriteLine("Insira um número ímpar: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 != 0)
            {

                //Imprimindo a parte de cima do diamante
                asteriscos = 1;
                espacos = (numero - 1) / 2;
                for (int linha = 1; espacos > 0; linha++)
                {

                    //Espaços
                    for (int count = 1; count <= espacos; count++)
                    {
                        Console.Write(" ");
                    }

                    //Asteriscos
                    for (int count = 1; count <= asteriscos; count++)
                    {
                        Console.Write("x");
                    }

                    espacos--;
                    asteriscos += 2;
                    Console.WriteLine();
                }

                //Imprimindo a parte de baixo do diamante
                for (int linha = 1; asteriscos > 0; linha++)
                {

                    //Espaços
                    for (int count = 1; count <= espacos; count++)
                    {
                        Console.Write(" ");
                    }

                    //Asteriscos
                    for (int count = 1; count <= asteriscos; count++)
                    {
                        Console.Write("x");
                    }

                    espacos++;
                    asteriscos -= 2;
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Não é ímpar!");
            }

            Console.ReadLine();
        }
    }
}
