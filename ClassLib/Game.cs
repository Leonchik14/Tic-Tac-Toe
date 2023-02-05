using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public static class Game
    {
        // Массив содержащий значения всех элементов поля.
        private static char[] _field = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        // Отрисовка поля.
        public static void DrawField()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", _field[1], _field[2], _field[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", _field[4], _field[5], _field[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", _field[7], _field[8], _field[9]);
            Console.WriteLine("     |     |      ");
        }
        /// <summary>
        /// Обработка выбранной пользователем позиции.
        /// </summary>
        /// <returns></returns>
        public static char ChoosePosition()
        {
            char position = 'a';
            Console.ForegroundColor = Console.BackgroundColor;
            ConsoleKeyInfo userkey = Console.ReadKey();    
            while (position == 'a')
            {
                switch (userkey.Key)
                {
                    case ConsoleKey.D1:
                        position = '1';
                        break;
                    case ConsoleKey.D2:
                        position = '2';
                        break;
                    case ConsoleKey.D3:
                        position = '3';
                        break;
                    case ConsoleKey.D4:
                        position = '4';
                        break;
                    case ConsoleKey.D5:
                        position = '5';
                        break;
                    case ConsoleKey.D6:
                        position = '6';
                        break;
                    case ConsoleKey.D7:
                        position = '7';
                        break;
                    case ConsoleKey.D8:
                        position = '8';
                        break;
                    case ConsoleKey.D9:
                        position = '9';
                        break;
                    default:
                        userkey = Console.ReadKey();
                        break;
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
            return position;
        }
        /// <summary>
        /// Метод, моделирующий ход игрока
        /// </summary>
        /// <param name="x">Булевое значение, отражающее является ли конкретный игрок крестиком.</param>
        public static void Turn(bool x)
        {
            char player = x ? 'X' : 'O';
            Console.WriteLine($"{player} turn! Choose your position!");
            _field[((int)ChoosePosition())-48] = player;
        }

        /// <summary>
        /// Проверка победы.
        /// </summary>
        /// <returns> 1 при победе, -1 при ничьей, 0 при продолжении игры.</returns>
        public static int CheckWin()
        {

            if (_field[1] == _field[2] && _field[2] == _field[3])
            {
                return 1;
            }

            else if (_field[4] == _field[5] && _field[5] == _field[6])
            {
                return 1;
            }

            else if (_field[6] == _field[7] && _field[7] == _field[8])
            {
                return 1;
            }

            else if (_field[1] == _field[4] && _field[4] == _field[7])
            {
                return 1;
            }

            else if (_field[2] == _field[5] && _field[5] == _field[8])
            {
                return 1;
            }

            else if (_field[3] == _field[6] && _field[6] == _field[9])
            {
                return 1;
            }
            else if (_field[1] == _field[5] && _field[5] == _field[9])
            {
                return 1;
            }
            else if (_field[3] == _field[5] && _field[5] == _field[7])
            {
                return 1;
            }

            else if (_field[1] != '1' && _field[2] != '2' && _field[3] != '3' && _field[4] != '4' && _field[5] != '5' &&
                _field[6] != '6' && _field[7] != '7' && _field[8] != '8' && _field[9] != '9')
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
        
        public static void WinMessage(char player)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Congratulations! {player} wins!");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void DrawMessage()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Draw!");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
