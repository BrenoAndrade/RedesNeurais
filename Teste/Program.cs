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
            Console.WriteLine("##### AND #####");
            Simples perceptronAND = new Simples(2);
            Simples perceptronA = new Simples(5);
            Simples perceptronT = new Simples(5);

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

           

            perceptronAND.Treinar(padroes, desejado, 0.2f);
            Console.ReadKey();

            //###################### TESTES ##############################

            Console.WriteLine("##### A #####");

            int[,] A =       {
                                {1, 1, 1, 1, 1},
                                {1, 0, 0, 0, 1},
                                {1, 0, 0, 0, 1},
                                {1, 1, 1, 1, 1},
                                {1, 0, 0, 0, 1}
                             };

            int[] desejadoA = {
                                1,
                                0,
                                0,
                                1,
                                0
                             };

            perceptronA.Treinar(A, desejadoA, 0.2f);

            Console.ReadKey();

            Console.WriteLine("##### T #####");

            int[,] T =       {
                                {1, 1, 1, 1, 1},
                                {0, 0, 1, 0, 0},
                                {0, 0, 1, 0, 0},
                                {0, 0, 1, 0, 0},
                                {0, 0, 1, 0, 0}
                             };

            int[] desejadoT = {
                                1,
                                0,
                                0,
                                0,
                                0
                             };
            perceptronT.Treinar(T, desejadoT, 0.2f);
            Console.ReadKey();
        }
    }
}
