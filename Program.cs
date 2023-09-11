namespace WeatherApp
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("    Welcome To    ");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("+-+-+-+-+-+-+-+-+-+\n|W|h|a|t|I|s|F|u|n|\n+-+-+-+-+-+-+-+-+-+");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  Weather System    \n");
            Console.ResetColor();
            Console.Write("Enter your city >>> ");
            string cityName = Console.ReadLine();

            string[] spinner = { "-", "\\", "|", "/" };

            Console.Write("Loading ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(spinner[i % spinner.Length]);
                Thread.Sleep(500);
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            }

            Console.WriteLine(" Complete!");
            Console.WriteLine("Idk, just look outside.");
            Console.ReadLine();

        }
    }
}