using System;

class GameDice
{
    static void Main(string[] args)
    {
        Random rnd = new Random();

        // Начало игры, принимаем ставку игрока
        Console.WriteLine("*** Are you in Game ***");
        Console.Write("\nEnter your bid (2...12): ");
        int rate0 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Bet placed: " + rate0 + ", no more bids\n");

        // Иммитация броска и подсчет очков
        int score0 = sum(RollTheDice(), RollTheDice()) - rate0; //подсчет  очков

        // Вывод результата
        if (score0 > 0)
        {
            Console.WriteLine("\nDefeated AI, win in {0} points!", score0);
        }
        else if (score0 < 0)
        {
            Console.WriteLine("\nYou won, win in {0} points!", Math.Abs(score0));
        }
        else
        {
            Console.WriteLine("\nDraw!");
        }

        // бросок
        int RollTheDice()
        {
            int number = rnd.Next(1, 7);
            PrintDice(number);
            return number;
        }

        // сумма
        int sum(int n1, int n2)
        {
            return n1 + n2;
        }

        // отрисовка кубика
        void PrintDice(int number)
        {
            switch (number)
            {
                case 1:
                    Console.WriteLine(" _______ ");
                    Console.WriteLine("|       |");
                    Console.WriteLine("|   O   |");
                    Console.WriteLine("|       |");
                    Console.WriteLine(" ------- ");
                    break;
                case 2:
                    Console.WriteLine(" _______ ");
                    Console.WriteLine("| O     |");
                    Console.WriteLine("|       |");
                    Console.WriteLine("|     O |");
                    Console.WriteLine(" ------- ");
                    break;
                case 3:
                    Console.WriteLine(" _______ ");
                    Console.WriteLine("| O     |");
                    Console.WriteLine("|   O   |");
                    Console.WriteLine("|     O |");
                    Console.WriteLine(" ------- ");
                    break;
                case 4:
                    Console.WriteLine(" _______ ");
                    Console.WriteLine("| O   O |");
                    Console.WriteLine("|       |");
                    Console.WriteLine("| O   O |");
                    Console.WriteLine(" ------- ");
                    break;
                case 5:
                    Console.WriteLine(" _______ ");
                    Console.WriteLine("| O   O |");
                    Console.WriteLine("|   O   |");
                    Console.WriteLine("| O   O |");
                    Console.WriteLine(" ------- ");
                    break;
                case 6:
                    Console.WriteLine(" _______ ");
                    Console.WriteLine("| O O O |");
                    Console.WriteLine("|       |");
                    Console.WriteLine("| O O O |");
                    Console.WriteLine(" ------- ");
                    break;
            }
        }
        // ожидание ввода
        Console.ReadLine();
    }
}