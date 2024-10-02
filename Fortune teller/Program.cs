internal class Program
{
    private static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("=".PadLeft(50, '='));
        Console.WriteLine("-- Bem-vindo(a) o mago da sorte --");
        Console.WriteLine("=".PadLeft(50, '='));
        Console.ResetColor();
        
        Random random = new Random();
        
        Console.WriteLine("Deseja consultar a sua fortuna?");
        string sorte = Console.ReadLine().ToLower();
        switch(sorte)
        {
            case "sim":
            if(random.Next(1, 11) == 1)
            {
              Console.ForegroundColor = ConsoleColor.Red;
              Console.WriteLine("=".PadLeft(50, '='));
              Console.WriteLine("A fumaça está vindo.");
              Console.WriteLine("=".PadLeft(50, '='));
              Console.ResetColor();
            }
            else if(random.Next(1, 11) == 2)
            {
              Console.ForegroundColor = ConsoleColor.DarkRed;
              Console.WriteLine("=".PadLeft(50, '='));
              Console.WriteLine("Corra");
              Console.WriteLine("=".PadLeft(50, '='));
              Console.ResetColor();
            }
            else if(random.Next(1, 11) == 3)
            {
              Console.ForegroundColor = ConsoleColor.Yellow;
              Console.WriteLine("=".PadLeft(50, '='));
              Console.WriteLine("Por favor deposite 5 moedas");
              Console.WriteLine("=".PadLeft(50, '='));
              Console.ResetColor();
            }
            else if(random.Next(1, 11) == 4)
            {
              Console.ForegroundColor = ConsoleColor.DarkGray;
              Console.WriteLine("=".PadLeft(50, '='));
              Console.WriteLine("Tente denovo mais tarde");
              Console.WriteLine("=".PadLeft(50, '='));
              Console.ResetColor();
            }
            else if(random.Next(1, 11) == 5)
            {
              Console.ForegroundColor = ConsoleColor.Magenta;
              Console.WriteLine("=".PadLeft(50, '='));
              Console.WriteLine("Busque conhecimento");
              Console.WriteLine("=".PadLeft(50, '='));
              Console.ResetColor();
            }
            else if(random.Next(1, 11) == 6)
            {
              Console.ForegroundColor = ConsoleColor.Green;
              Console.WriteLine("=".PadLeft(50, '='));
              Console.WriteLine("Tirou o bolao +$5000");
              Console.WriteLine("=".PadLeft(50, '='));
              Console.ResetColor();
            }
            else if(random.Next(1, 11) == 7)
            {
              Console.ForegroundColor = ConsoleColor.DarkRed;
              Console.WriteLine("=".PadLeft(50, '='));
              Console.WriteLine("Olho por olho e o mundo acabará cego");
              Console.WriteLine("=".PadLeft(50, '='));
              Console.ResetColor();
            }
            else if(random.Next(1, 11) == 8)
            {
              Console.ForegroundColor = ConsoleColor.Magenta;
              Console.WriteLine("=".PadLeft(50, '='));
              Console.WriteLine("Você fará um novo amigo");
              Console.WriteLine("=".PadLeft(50, '='));
              Console.ResetColor();
            }
            else if(random.Next(1, 11) == 9)
            {
              Console.ForegroundColor = ConsoleColor.Yellow;
              Console.WriteLine("=".PadLeft(50, '='));
              Console.WriteLine("Lendária");
              Console.WriteLine("=".PadLeft(50, '='));
              Console.ResetColor();
            }
            else if(random.Next(1, 11) == 10)
            {
              Console.ForegroundColor = ConsoleColor.Blue;
              Console.WriteLine("=".PadLeft(50, '='));
              Console.WriteLine("Há uma oportunidade na sua frente\nela está correndo de você");
              Console.WriteLine("=".PadLeft(50, '='));
              Console.ResetColor();
            }
            break;
            case "nao":
            Console.WriteLine("Você perdeu uma grande chance.");
            break;
        }

    }
}