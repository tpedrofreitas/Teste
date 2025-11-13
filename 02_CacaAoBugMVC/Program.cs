using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CacaAoBugMVC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Passagem de Parâmetro por valor ***");
            //Passa o conteúdo da varíavel de Origem para a varíavel de Destino
            //O método de destino não altera o valor da variavel do método da origem,
            double valor = 10;
            if(PassagemParametroValor(valor)) 
            Console.WriteLine($"Valor do método Main->PassagemParametroValor {valor}");
            Console.WriteLine("\n\n*** Passagem de Parâmetro por Referência REF ***");
            //Passa o endereço de memória da varíavel de Origem para varíavel de Destino
            //O varíavel de origem pode estar inicializada
            //O método de destino pode alterar o valor da varíavel do método de origem

            double valor1 = 10;
            if(PassagemParametroReferenciaRef( ref valor1))
            {
                Console.WriteLine($"Valor do método Main-> PassagemParametroReferenciaRef {valor1}");
            }

            Console.WriteLine("\n\n*** Passagem de Parâmetro por Referência OUT ***");
            //Passa o endereço de memória da varíavel de Origem para a varíavel de Destino
            //O varíavel  de origem não pode estar inicializada
            //O método de destino deve incializar a variavel do metodo de origem
            //O método de destino pode alterar o valor da variável do método de origem
            double valor2 = 10;
            if (PassagemParametroReferenciaOut(out valor2))
            {
                Console.WriteLine($"Valor do método Main-> PassagemParametroReferenciaOut {valor2}");
            }
            Console.WriteLine("\n\n*** Passagem de Parâmetro  por Referência IN ***");
            //Passa o endereço da memória da variável de Origem para variável de Destino
            //O variável de origem deve estar inicializada
            //O método do destino não pode alterar o valor da variável do método devorigem
            double valor3 = 100;
            if(PassagemParametroReferenciaIN(in valor3))
            {
                Console.WriteLine($"Valor do método Main-> PassagemParametroReferenciaIN {valor3}");
            }
        }
        public static bool PassagemParametroValor(double valor)
        {
            valor = valor * 10;
            Console.WriteLine($"Valor do método PassagemParametroValor {valor}");
            return true;
        }
        public static bool PassagemParametroReferenciaRef(ref double valor1)
        {
            valor1 = valor1 * 10;
            Console.WriteLine($"Valor do método PassagemParametroReferenciaRef {valor1}");
            return true;
        }
        public static bool PassagemParametroReferenciaOut(out double valor2)
        {
            valor2 = 10;
            valor2 = valor2 * 10;
            Console.WriteLine($"Valor do método PassagemParametroReferenciaOut {valor2}");
            return true;
        }
        public static bool PassagemParametroReferenciaIN(in double valor3)
        {
           // IN somente pra leitura
            Console.WriteLine($"Valor do método PassagemParametroReferenciaIN {valor3}");
            return true;
        }
    }
}
