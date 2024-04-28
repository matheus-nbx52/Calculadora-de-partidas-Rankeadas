using System;

namespace CalculadoraPartidasRankeadas
{
    class Program
    {
        static void Main(string[] args)
        {
            int vitorias = 0;
            int derrotas = 0;

            while (true)
            {
                Console.WriteLine("Digite a quantidade de vitórias (ou digite '0' para sair):");
                int entradaVitorias = int.Parse(Console.ReadLine());

                if (entradaVitorias == 0)
                    break; // Sai do loop se o usuário digitar 0

                Console.WriteLine("Digite a quantidade de derrotas:");
                int entradaDerrotas = int.Parse(Console.ReadLine());

                vitorias += entradaVitorias;
                derrotas += entradaDerrotas;
            }

            string nivel = CalcularNivel(vitorias, derrotas);

            Console.WriteLine($"O Herói tem um saldo de {vitorias - derrotas} e está no nível de {nivel}");
        }

        static string CalcularNivel(int vitorias, int derrotas)
        {
            int saldo = vitorias - derrotas;

            if (saldo < 10)
                return "Ferro";
            else if (saldo >= 11 && saldo <= 20)
                return "Bronze";
            else if (saldo >= 21 && saldo <= 50)
                return "Prata";
            else if (saldo >= 51 && saldo <= 80)
                return "Ouro";
            else if (saldo >= 81 && saldo <= 90)
                return "Diamante";
            else if (saldo >= 91 && saldo <= 100)
                return "Lendário";
            else
                return "Imortal";
        }
    }
}
