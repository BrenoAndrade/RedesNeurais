using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Perceptron;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            Simples perceptron = new Simples(2);
                

            int[,] padroes = {
                                {0, 0},
                                {0, 1},
                                {1, 0},
                                {1, 1}
                             };

            int[] desejado = {
                                0,
                                0,
                                0,
                                1
                             };
            
            perceptron.Treinar(padroes, desejado, 0.5f);



            Console.ReadKey();
        }
    }
}
