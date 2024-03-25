namespace Link_in_csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LINQ in C#.......");
            // LearningLINQ lq = new LearningLINQ();
            // lq.ManipulateLINQ();
            Console.WriteLine();

            Business bus = new Business();
            bus.ManipulateBusiness();
            Console.WriteLine();

            Game game = new Game();
            game.ManipulateGame();

            Music music = new Music();
            music.ManipulateMusic();
        }
    }
}
