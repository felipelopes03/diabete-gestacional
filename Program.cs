Console.Clear();
int avaliacao;
 
    Console.WriteLine("- DIABETES GESTACIONAIS -");
    
    Console.WriteLine("Digite a sua glicose:");
   avaliacao = Convert.ToInt32(Console.ReadLine());

if(avaliacao < 92)
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;

        Console.Write("Reavaliar entre 24 e 28 semanas com TTOG 75g de glicose:");
    }

if(avaliacao < 126 && avaliacao >= 92)
{
     Console.ForegroundColor = ConsoleColor.Red;

      Console.Write("Compatível com diabete gestacionail.");
}
if(avaliacao >= 126)
{
     Console.ForegroundColor = ConsoleColor.Green;

      Console.Write("Diabetes Mellitus na gravidez.");
}
Console.ResetColor();
