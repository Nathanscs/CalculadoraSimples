using System;

namespace Ex1
{
    public class Calculadora
    {
        public int soma;

        public float divisao;

        public float multiplicacao;

        public int subtracao;

        public int potencia;

        public int raizQuadrada;

    }

    class Program
    {
        static void Main(string[] args)
        {
            int v1, v2;
            string funcao;

            Console.WriteLine("Escreva o primeiro valor: ");
            v1=int.Parse(Console.ReadLine());
            Console.WriteLine("Adição: +\nSubtração: -\nMultiplicação: *\nDivisão: /\nRaiz Quadrada: //\n\nEscolha a função: ");
            funcao=Console.ReadLine();
            
            
            if(funcao == "+")
            {
                Console.WriteLine("Escreva o segundo valor: ");
                v2=int.Parse(Console.ReadLine());
                
                Console.WriteLine("{0} + {1} = {2}", v1, v2, v1+v2);
            }
            if(funcao == "/")
            {
                Console.WriteLine("Escreva o segundo valor: ");
                v2=int.Parse(Console.ReadLine());

                Console.WriteLine("{0} + {1} = {2}", v1, v2, v1/v2);
            }
            if(funcao == "*")
            {
                Console.WriteLine("Escreva o segundo valor: ");
                v2=int.Parse(Console.ReadLine());

                Console.WriteLine("{0} + {1} = {2}", v1, v2, v1*v2);
            }
            if(funcao == "-")
            {
                Console.WriteLine("Escreva o segundo valor: ");
                v2=int.Parse(Console.ReadLine());

                Console.WriteLine("{0} + {1} = {2}", v1, v2, v1-v2);
            }
            if(funcao == "//")
            {
                int raiz;

                for(int i= 0; i == i; i++)
                {
                    raiz = i * i;

                    if(raiz == v1)
                    {

                        Console.WriteLine("{0} // = {1}", v1, i);
                    }
                }
            }
        }
    }
}

