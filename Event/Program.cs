namespace Event
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            player.OnDeath += EnemyVictory;
            player.OnDeath += ShowGame;
            player.TakeDamage(100);
        }
        static void ShowGame()
        {
            Console.WriteLine("GAME OVER");
        }
        static void EnemyVictory()
        {
            Console.WriteLine("Враги празнуют победу!");
        }
    }
}
