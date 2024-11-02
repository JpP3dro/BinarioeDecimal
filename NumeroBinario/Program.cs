using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroBinario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programa que transforma binário em número decimal e vice-versa
            Console.WriteLine("Digite 1 para transformar binário em decimal");
            Console.WriteLine("Digite 2 para transformar decimal em binário");
            int escolha = Convert.ToInt32(Console.ReadLine());

            //Verifica qual foi o número escolhido
            switch (escolha){
                case 1:
                    Console.WriteLine("Digite um número binário");
                    string binario = Console.ReadLine();
                    Console.WriteLine(BinarioToDecimal(binario));
                    break;
                case 2:
                    Console.WriteLine("Digite um número decimal");
                    int numero = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(DecimalToBinario(numero));
                    break;
                default:
                    Console.WriteLine("Escolha inválida!");
                    break;
            }
            Console.ReadKey();
        }

        private static string DecimalToBinario(int numero)
        {
            /*Maneira mais fácil de fazer:
             Usar essa função -> string binario = Convert.ToString(decimalValue, 2);
             */
            string binario = "";
            while (numero > 0)
            {
                int resto = numero % 2;
                binario = resto + binario;
                numero /= 2;
            }
            //Se binário for vazio então ele é igual 0
            binario = binario == "" ? "0" : binario;
            return binario;

        }

        private static int BinarioToDecimal(string numero)
        {
            /*Maneira mais fácil de fazer:
             Usar essa função -> Convert.ToInt32(numero, 2);
             */
            //Cria a variável que vai adicionar ao valor
            int valor = 0;
            
            //Verifica cada caractere do número binário
            for (int i = 0;i < numero.Length;i++)
            {
                char bit = numero[numero.Length - 1 - i];
                if (bit == '1')
                {
                    valor += (int)Math.Pow(2, i);
                }
                //Se um caractere não for nem 1, nem 0, ele para e retorna 0
                else if (bit != '0')
                {
                    return 0;
                }
            }
            return valor;
        }
    }
}
