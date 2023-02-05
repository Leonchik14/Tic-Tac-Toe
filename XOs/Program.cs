using ClassLib;

namespace XOs
{
    internal class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            bool xFirst = rnd.Next(0, 2) == 1 ? true : false;
            bool playerX = xFirst;
            Console.CursorVisible = false;
            while (Game.CheckWin() == 0)
            {
                Console.Clear();
                Game.DrawField();
                Game.Turn(playerX);
                playerX = !playerX;
            }
            if (Game.CheckWin() == 1)
            {
                Console.Clear();
                Game.DrawField();
                Game.WinMessage(!playerX == true ? 'X' : 'O');
            }
            else
            {
                Console.Clear();
                Game.DrawField();
                Game.DrawMessage();
            }
        }
    }
}