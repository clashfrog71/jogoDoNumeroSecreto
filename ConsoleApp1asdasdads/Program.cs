using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace Programasuperprotegidocom;


public static class Program
{
    public static void Main()
    {
        Console.WriteLine("Jogo do numero secreto ver 0.1");
        Console.WriteLine("1:entrar no jogo");
        Console.WriteLine("2:sair do jogo");
        Console.WriteLine("3:placar de tentativas");
        int escolhedor = int.Parse(Console.ReadLine());
        switch (escolhedor)
        {

            case 2:
                Console.Clear();
                Console.Write("Tchau :)");
                break;
            case 1:
                Console.Clear();
                Random senhasecreta = new Random();
                double randomva = senhasecreta.NextDouble();
                int numerodetentativas = 5;
                int numerosortudo = 10;
                int senha = senhasecreta.Next(1, numerosortudo);
                for (int i = 0; i < numerodetentativas;)
                {
                    var tentativasreais = numerodetentativas - i;
                    var mensagem = $"ache a senha entre 1 e {numerosortudo}: ({tentativasreais}) tentativas";

                    Console.WriteLine(mensagem);
                    i++;
                    var tentativa = int.Parse(Console.ReadLine());
                    if (tentativa == senha)
                    {
                        Console.Clear();
                        Console.WriteLine($"Voce descubriu a senha! ({senha}) com {i} tentativa(s)");
                        Console.ReadLine();
                        Console.Clear();
                        senha = senhasecreta.Next(1, numerosortudo);
                        i = 0;
                    }
                    else
                    {
                        Console.Clear();
                        if (i == numerodetentativas)
                        {
                            Console.WriteLine($"você atingiu o limite de tentativas, a senha era {senha}, mudando senha...");
                            Console.Read();
                            Console.Clear();
                            senha = senhasecreta.Next(1, numerosortudo);
                            i = 0;
                        }
                        else { }
                    }
                }
                break;
            case 3:
                Console.Clear();
                Console.WriteLine("Top 10 jogadores com menos tentativas");

                break;
        }
    }
}