namespace Kochen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Kochen automat1 = new Kochen(800,500,200,400);

            automat1.Auswahl();     

            Console.ResetColor();
        }

    }
}
