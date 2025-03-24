Console.Clear();

string especie;
string raca;
string alcunha;
string idade;
string pelo;


Console.WriteLine("Digite a espécie do pet!");
especie = Console.ReadLine();

Console.WriteLine("Digite a raça do pet!");
raca = Console.ReadLine();

Console.WriteLine("Digite a alcunha pela qual seu pet atende!");
alcunha = Console.ReadLine();

Console.WriteLine("Digite a idade do pet!");
idade = Console.ReadLine();

Console.WriteLine("Digite o pelo/cor do pet!");
pelo = Console.ReadLine();


Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("+=========================================================+");


Console.Write("|                 ");

Console.ForegroundColor = ConsoleColor.Red;
Console.Write("Pet Hotel 'Nem um pio'");

Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("                  |");

Console.WriteLine("+=========================================================+");


Console.Write("| ");

Console.ForegroundColor = ConsoleColor.Red;
Console.Write($"Espécie: {especie.PadLeft(15, '.')}"); //15

Console.ForegroundColor = ConsoleColor.DarkGray;
Console.Write(" | ");

Console.ForegroundColor = ConsoleColor.Red;
Console.Write($"Raça: {raca.PadLeft(22, '.')}"); //22

Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine(" |");


Console.WriteLine("+=========================================================+");


Console.Write("| ");

Console.ForegroundColor = ConsoleColor.Red;
Console.Write($"Atende pela alcunha de: {alcunha.PadLeft(31, '.')}");//31

Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine(" |");


Console.Write("| ");

Console.ForegroundColor = ConsoleColor.Red;
Console.Write($"Idade: {idade.PadLeft(2, '0')} ano(s)"); //00

Console.ForegroundColor = ConsoleColor.DarkGray;
Console.Write(" | ");

Console.ForegroundColor = ConsoleColor.Red;
Console.Write($"Pelagem/cor: {pelo.PadLeft(23, '.')}"); //23

Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine(" |");

Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("+=========================================================+");

Console.ResetColor();