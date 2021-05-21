
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Calculadora
{
    public class CalculadoraCadastro
    {
        public void Main(string[] args)


        {

            string NomeCliente;

            decimal MoedaOrigem, MoedaDestino;

            bool Real;

           



            // Nome Cliente 

            Console.WriteLine("Digite seu nome:");

            NomeCliente = Console.ReadLine();

            Console.Clear();


            Console.WriteLine("---------------- OLÁ ------------------" + NomeCliente);


            // Determinando valores
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Digite a moeda que deseja converter:");
            Console.WriteLine("- Libra - Real - Peso - Dolar - Euro -");

            MoedaOrigem = Convert.ToInt64(Console.ReadLine());


            if (MoedaOrigem = Euro)
            {

                Console.WriteLine("Digite o valor que deseja converter - Libra - Real - Peso - Dolar - Euro-");
                MoedaDestino = Convert.ToInt32(Console.ReadLine();

                Console.WriteLine("Multiplando valores Euro x Valor Da converção desejada ");
                Console.WriteLine("Valor Convertido De Dolar" + MoedaOrigem * MoedaDestino);
            }

            
            else if (MoedaOrigem = Dolar)
            {
               
                Console.WriteLine("Digite o valor que deseja converter");
                MoedaDestino = Console.ReadLine();
                Console.WriteLine("Multiplando valores Dolar x Valor Da converção desejada ");


                Console.WriteLine("Valor Convertido De Dolar" + MoedaOrigem * MoedaDestino);
            }
            else if (MoedaOrigem = Peso)
            {
              
                Console.WriteLine("Digite o valor que deseja converter");
                MoedaDestino = Console.ReadLine();
                Console.WriteLine("Multiplando valores Peso x Valor Da converção desejada ");


                Console.WriteLine("Valor Convertido De Dolar" + MoedaOrigem * MoedaDestino);
            }
            else if (MoedaOrigem = Libra)
            {
               
                Console.WriteLine("Digite o valor que deseja converter");
                MoedaDestino = Console.ReadLine();

                Console.WriteLine("Multiplando valores Libra x Valor Da converção desejada ");

                Console.WriteLine("Valor Convertido De Dolar" + MoedaOrigem * MoedaDestino);
            }
            else 
            {
                Console.WriteLine("Escreva Moeda valida - Dolar- Peso - Real - Euro - Libra");
            }
        


            Console.Clear();


            Console.WriteLine("---- DATA DA OPERAÇÃO ----");
            DateTime DataOperação = DateTime.Now;

            Console.WriteLine(DataOperação);




        
        }


    }
}
