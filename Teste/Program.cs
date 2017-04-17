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
            Console.WriteLine("##### XOR #####");

            int[,] entradas = {
                                {0, 0},
                                {0, 1},
                                {1, 0},
                                {1, 1}
                             };

            int[,] entradasP3 = {
                                    {0, 1}, //0
                                    {1, 0}, //0
                                    {1, 1}  //1
                                };

            int[] desejadoP1 = { 1, 1, 1, 0};
            int[] desejadoP2 = { 0, 1, 1, 1};
            int[] desejadoP3 = { 0, 0, 1};

            Simples perceptronP1 = new Simples(2);
            Simples perceptronP2 = new Simples(2);
            Simples perceptronP3 = new Simples(2);

            perceptronP1.Treinar(entradas, desejadoP1, 0.2f);
            perceptronP2.Treinar(entradas, desejadoP2, 0.2f);
            perceptronP3.Treinar(entradasP3, desejadoP3, 0.2f);

            int[] X = new int[3]; // Posição zero não conta -- sempre da X[1] e X[2]

            X[1] = 0;
            X[2] = 1;

            int s1 = perceptronP1.Y(X);
            int s2 = perceptronP2.Y(X);
            Console.WriteLine("Saída para {0}, {1} = {2}", X[1], X[2], perceptronP3.Y(new int[] { 1 , s1, s2 }));
            Console.ReadKey();

            X[1] = 1; // Posição zero não conta -- sempre da X[1] e X[2]
            X[2] = 0;

            s1 = perceptronP1.Y(X);
            s2 = perceptronP2.Y(X);
            Console.WriteLine("Saída para {0}, {1} = {2}", X[1], X[2], perceptronP3.Y(new int[] { 1, s1, s2 }));
            Console.ReadKey();

            X[1] = 1; // Posição zero não conta -- sempre da X[1] e X[2]
            X[2] = 1;    

            s1 = perceptronP1.Y(X);
            s2 = perceptronP2.Y(X);
            Console.WriteLine("Saída para {0}, {1} = {2}", X[1], X[2], perceptronP3.Y(new int[] { 1, s1, s2 }));
            Console.ReadKey();

            /*
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
            */
        }
    }
}
