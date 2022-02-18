using System;

namespace Desafio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantiade de números q serão lidos: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());  
            int[] numeros = new int[quantidade];

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Digite o número da posição " + i + ":");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            int repete = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                for (int j = 0; j < numeros.Length; j++)
                {
                    if(numeros[i] == numeros[j] && j < i)
                    {
                        repete++;
                    }
                }
            }

            int[] numerosSemRepetir = new int[repete];
            Console.WriteLine(repete);

            for (int k = 0; k < numerosSemRepetir.Length ; k++)
            {
                int apelei = k - 1;
                for (int i = 0; i < numeros.Length; i++)
                {
                    for (int j = 0; j < numeros.Length; j++)
                    {
                        if (k == 0)
                        {
                            numerosSemRepetir[0]=numeros[0];
                        }
                        else if (numeros[i] == numeros[j] && j < i && numerosSemRepetir[apelei] != numeros[i])
                        {
                            numerosSemRepetir[k] = numeros[i];
                        }
                    }
                }
            }

            for (int i = 0; i < numerosSemRepetir.Length ; i++)
            {
                Console.WriteLine(numerosSemRepetir[i]);
            }
        }
    }
}
