namespace DPTemplateMethodProject
{
   


    internal class Program
    {
        static void Main(string[] args)
        {
            WindowTemlate form = new FormWindow();
            WindowTemlate game = new GameWindow();

            game.CreateWindow();
            Console.WriteLine();
            form.CreateWindow();
        }
    }
}