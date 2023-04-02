using System;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("+=========================================================+");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("|                 Pet Hotel \"Nem um pio\"                  |");
        Console.ResetColor();
        Console.WriteLine("+=========================================================+\n");

        Console.WriteLine("Por favor, informe os dados do pet:\n");

        Console.Write("Espécie: ");
        string especie = Console.ReadLine();

        Console.Write("Raça: ");
        string raca = Console.ReadLine();

        Console.Write("Atende pela alcunha de: ");
        string nome = Console.ReadLine();

        Console.Write("Idade: ");
        int idade = int.Parse(Console.ReadLine());

        Console.Write("Pelagem/cor: ");
        string pelagem = Console.ReadLine();

        Console.WriteLine("\n+=========================================================+");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("|                 Pet Hotel \"Nem um pio\"                  |");
        Console.ResetColor();
        Console.WriteLine("+=========================================================+");
        Console.WriteLine("| Espécie: ............" + especie.ToUpper().PadRight(14) + "| Raça: ............" + raca.ToUpper().PadRight(14) + "|");
        Console.WriteLine("+=========================================================+");
        Console.WriteLine("| Atende pela alcunha de: ..........................." + nome.ToUpper().PadRight(14) + "| Idade: " + idade.ToString().PadRight(3) + " ano(s) | Pelagem/cor: ..............." + pelagem.ToUpper().PadRight(14) + "|");
        Console.WriteLine("+=========================================================+");
    }
}
