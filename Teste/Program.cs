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
            Console.WriteLine("Precione enter para continuar!!!!!!!");
            Console.ReadKey();

            //###################### TESTES ##############################
            
            Console.WriteLine("##### A ou T #####");

            Simples perceptronAouT = new Simples(25);

            int[,] AouT =   {
                                {1, 1, 1, 1, 1,
                                 1, 0, 0, 0, 1,
                                 1, 0, 0, 0, 1,
                                 1, 1, 1, 1, 1,
                                 1, 0, 0, 0, 1},
                                
                                {1, 1, 1, 1, 1,
                                 0, 0, 1, 0, 0,
                                 0, 0, 1, 0, 0,
                                 0, 0, 1, 0, 0,
                                 0, 0, 1, 0, 0}       
                             };

            int[] desejadoAouT = {
                                0,
                                1
                             };

            perceptronAouT.Treinar(AouT, desejadoAouT, 0.2f);
            Console.ReadKey();
        }
    }
}
