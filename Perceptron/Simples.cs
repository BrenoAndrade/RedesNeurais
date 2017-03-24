using System;
using System.Collections.Generic;

namespace Perceptron
{
    public class Simples
    {
        private Random NumeroAleatorio = new Random();
        private float[] Pesos;

        private int quantidadeEntradas;
        private int min = -1;
        private int max = 1;
        private bool treinou;

        public Simples(int quantidadeEntradas)
        {
            this.quantidadeEntradas = quantidadeEntradas;
            this.Pesos = new float[quantidadeEntradas + 1];
            this.treinou = false;

            GerarPesos();
        }

        public void Treinar(int[,] padroes, int[] desejado, float eta)
        {
            while (!treinou)
            {
                for (int k = 0; k <= 3; k++) //AND
                {
                    int[] entradas = new int[quantidadeEntradas + 1];

                    for (int i = 0; i < quantidadeEntradas; i++)
                    {
                        entradas[i + 1] = padroes[k, i];
                    }

                    int valorY= Y(entradas);

                    for (int i = 1; i <= quantidadeEntradas; i++)
                    {
                        Console.Write("E" + i +": " + entradas[i] + "\t");
                    }

                    Console.Write("Y:" + valorY + " ---> " + desejado[k] + "\n");

                    for (int i = 1; i <= quantidadeEntradas; i++)
                    {
                        Console.Write("W" + i + ": " + Pesos[i] + "\t");
                    }

                    Console.Write("\n\n");

                    treinou = valorY == desejado[k] ? true : false;
                    float erro = desejado[k] - valorY;
                                        
                    if(erro != 0)
                    {
                        for (int i = 0; i <= quantidadeEntradas; i++)
                        {
                            Pesos[i] = Pesos[i] + eta * erro * entradas[i];
                        }
                        treinou = false;
                        k = -1;
                        Console.WriteLine("-------- PESOS RECALCULADOS ---------");
                    }
                        
                }          
                
                Console.WriteLine("------- FIM ITERACAO ----------");
            }
            Console.WriteLine("GG");
        }

        private int Y(int[] entradas)
        {
            return Somatorio(entradas) > 0 ? 1 : 0;
        }

        private float Somatorio(int[] entradas)
        {
            float soma = 0;
            entradas[0] = 1;

            for (int i = 0; i < entradas.Length; i++)
            {
                soma += entradas[i] * Pesos[i];
            }

            return soma;
        }

        private void GerarPesos()
        {
            Pesos[0] = 1;

            for (int i = 1; i < this.quantidadeEntradas + 1 ; i++)
            {
                float peso = GerarNumeroFloatAleatorio(min, max);
                Pesos[i] = peso;
            }
        }
        
        private float GerarNumeroFloatAleatorio(int min, int max)
        {
            int numeroInteiro = NumeroAleatorio.Next(min, max);

            if (numeroInteiro == max)
            {
                return Convert.ToSingle(numeroInteiro) - Convert.ToSingle(NumeroAleatorio.NextDouble());
            }

            return Convert.ToSingle(numeroInteiro) + Convert.ToSingle(NumeroAleatorio.NextDouble());
        }
    }
}
