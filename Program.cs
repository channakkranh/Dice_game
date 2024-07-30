namespace Dice_game
{
    internal class Program
    {
        static void Main(string[] args)
            
        {
            int playerRandomNum;
            int enemyRandomNum;
            int playerPoint = 0;
            int enemyPoint = 0;

            Console.WriteLine("Welcome to To Dice Game !");
            Random ra = new Random();

            for (int i=0;i<10;i++)
            {
                Console.WriteLine("Press Any key to Rool Dice ");
                Console.ReadKey();
                playerRandomNum = ra.Next(1, 7);
                Console.WriteLine($"You rolled Number is : {playerRandomNum}");

                Console.WriteLine("=======");
                System.Threading.Thread.Sleep(1000);

                enemyRandomNum = ra.Next(1, 7);
                Console.WriteLine($"Enimy rolled is :{enemyRandomNum}");

                Console.WriteLine("================================");

                if ( playerRandomNum>enemyRandomNum)
                {
                    playerPoint++;
                    Console.WriteLine("Player Win this round !");
                }
                else if (playerRandomNum<enemyRandomNum)
                {
                    enemyPoint++;
                    Console.WriteLine("Enemy Win this round !");
                }
                else
                {
                    Console.WriteLine("You have Draw!");
                }
                Console.WriteLine($"Scord this roun is Player={playerPoint} & Ememy={enemyPoint}");
            }
            Console.WriteLine("Thank for your play this game!");
           
            Console.ReadKey();
        }
    }
}
