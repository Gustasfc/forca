string letra, forca;
Console.WriteLine ("Escreva uma Palavra: ");
forca = Console.ReadLine().ToUpper();
Console.WriteLine ("Escreva uma Letra da Forca ");
letra = Console.ReadLine().ToUpper();
Console.WriteLine($"Essa letra {letra} esta em {forca}? \n{forca.Contains(letra)}");