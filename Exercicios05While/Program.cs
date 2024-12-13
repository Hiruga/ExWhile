using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios05While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Contagem regressiva 

            int count = 10;

            Console.WriteLine("Contagem regressiva...");
            while (count > -1)
            {
                Console.WriteLine(count);
                count--;
            }*/

            /* Soma infinita

            int x = 1;
            int y = 1;
            int soma;
            int somat = 0;

            Console.WriteLine("Soma infinita (Cuidado!)");
            Console.WriteLine("Envie 0 em qualquer valor para encerrar o programa.");

            while(x > 0 && y > 0)
            {
                Console.WriteLine("Envie os valores de X e Y para serem somados");
                Console.Write("Valor de X: ");
                x = int.Parse(Console.ReadLine());
                Console.Write("Valor de Y: ");
                y = int.Parse(Console.ReadLine());
                soma = x + y + somat;
                Console.WriteLine("A soma dos valores enviados é: "+soma);
                somat = soma;
            }*/

            /* Tabuada 
            int tab = 1, x;

            Console.WriteLine("Contador de tabuada (Até o 10!)");
            Console.Write("Envie o número que você quer calcular: ");
            x = int.Parse(Console.ReadLine());

            while(tab <= 10)
            {
                Console.WriteLine(tab * x);
                tab++;
            }*/

            /* Média de notas 

            int als = 1, n1, n2, n3, n4;
            float media;
            string nome;

            Console.WriteLine("Calculador de média de alunos");

            while (als <= 5)
            {
                Console.Write("Envie o nome do aluno: ");
                nome = Console.ReadLine();
                Console.WriteLine("Envie o valor das notas");

                Console.Write("Primeira nota: ");
                n1 = int.Parse(Console.ReadLine());
                Console.Write("Segunda nota: ");
                n2 = int.Parse(Console.ReadLine());
                Console.Write("Terceira nota: ");
                n3 = int.Parse(Console.ReadLine());
                Console.Write("Quarta nota: ");
                n4 = int.Parse(Console.ReadLine());

                Console.Clear();
                media = (n1 + n2 + n3 + n4)/4f;
                Console.WriteLine("A média das notas do aluno " + nome + " é " + media);
                Console.WriteLine("Pressione qualquer tecla para seguir para o próximo aluno.");
                Console.ReadKey();

                als++;
            }*/

            /* Concurso de sorte
            Random rng = new Random();

            int ent = 0, num = 0;

            Console.WriteLine("Concurso de sorte!");
            Console.WriteLine("Adivinhe o número gerado pelo programa para sair com sucesso.");
            num = rng.Next(101);
            Console.WriteLine("O programa escolheu um número entre 0 e 100.");
            Console.WriteLine("Pressione qualquer tecla para continuar.");
            Console.ReadKey();
            Console.Clear();

            while (ent != num)
            {
                Console.WriteLine("Espero que não seja sua primeira vez aqui.");
                Console.Write("Tente adivinhar o número: ");
                ent = int.Parse(Console.ReadLine());
                if (ent == num)
                {
                    Console.WriteLine("Parabéns, você acertou!!!");
                    Console.WriteLine("Acho que foi sorte.");
                    Console.WriteLine("Nos despedimos aqui.");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Uma pena... Você falhou.");
                    Console.WriteLine("Boa sorte na próxima tentativa.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }*/

            /* Senha inválida 

            string senha = "";

            while (senha != "2002")
            {

                Console.Write("Envie a senha: ");
                senha = Console.ReadLine();
                if(senha == "2002")
                {
                    Console.WriteLine("Acesso permitido.");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.Write("Senha inválida, tente novamente.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }*/

            Console.WriteLine("Programa encerrado.");
            Console.ReadKey();
        }
    }
}
