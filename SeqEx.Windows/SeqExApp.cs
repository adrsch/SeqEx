using Stride.Engine;

namespace SeqEx
{
    class SeqExApp
    {
        static void Main(string[] args)
        {
            using (var game = new SeqExGame())
            {
                game.Init();
                game.Run();
            }
        }
    }
}
