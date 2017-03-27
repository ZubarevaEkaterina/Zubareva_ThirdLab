using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SecondLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which of three version do you want to play?");
            start1:
            int version_of_the_game = Convert.ToInt32(Console.ReadLine());

            if (version_of_the_game >3 || version_of_the_game < 1)
            {
                Console.WriteLine("Sorry: this version doesn't exist, please, try again");
                goto start1;
            }

            if (version_of_the_game == 1)
            {
                Console.WriteLine("Do you want to take values for field from a file? \nYes - enter , no - press any other key");

                ConsoleKeyInfo answer = Console.ReadKey();

                Game game;
                if (answer.Key == ConsoleKey.Enter)
                {
                    StreamReader file = new StreamReader(@"C:\Users\User\Desktop\laba\text.txt");
                    game = new Game(txt_file.reader(file));
                }

                else game = new Game(1, 2, 3, 4, 5, 6, 7, 0, 8);


                Console.WriteLine();
                Printer.Print(game);
                int temp = 0;
                while (temp != 1)
                {
                    Console.WriteLine("Enter the value you want to move");
                    start:
                    int value = 0;

                    value = Convert.ToInt32(Console.ReadLine());


                    if (value <= 0 || value >= game.Field.Length)
                    {
                        Console.WriteLine("Error: this value doesn't exist");
                        goto start;
                    }


                    if (game.Shift(value) == false)
                    {
                        Console.WriteLine("Error: Change your value, because you can't move it");
                        goto start;
                    }

                    Console.WriteLine();

                    Printer.Print(game);
                }

            }

            if (version_of_the_game == 2)
            {
                Console.WriteLine("Do you want to take values for field from a file? \nYes - enter , no - press any other key");

                ConsoleKeyInfo answer = Console.ReadKey();

                Game2 game;
                if (answer.Key == ConsoleKey.Enter)
                {
                    StreamReader file = new StreamReader(@"C:\Users\User\Desktop\laba\text.txt");
                    game = new Game2(txt_file.reader(file));
                }


                else game = new Game2(1, 2, 3, 4, 5, 6, 7, 0, 8);


                Printer.Print(game);


                while (!game.End_of_the_game)
                {

                    Console.WriteLine("Enter the value you want to move");
                    start:
                    int value = 0;

                    value = Convert.ToInt32(Console.ReadLine());

                    if (value <= 0 || value >= game.Field.Length)
                    {
                        Console.WriteLine("Error: this value doesn't exist");
                        goto start;
                    }


                    if (game.Shift(value) == false)
                    {
                        Console.WriteLine("Error: Change your value, because you can't move it");
                        goto start;
                    }

                  
                    Console.WriteLine();

                    Printer.Print(game);

                }
                Console.WriteLine("Game over. You win!");




            }

            if (version_of_the_game == 3)
            {
                Console.WriteLine("Do you want to take values for field from a file? \nYes - enter , no - press any other key");

                ConsoleKeyInfo answer = Console.ReadKey();

                Game3 game;
                if (answer.Key == ConsoleKey.Enter)
                {
                    StreamReader file = new StreamReader(@"C:\Users\User\Desktop\laba\text.txt");
                    game = new Game3(txt_file.reader(file));
                }


                else game = new Game3(1, 2, 3, 4, 5, 6, 7, 0, 8);

                Console.WriteLine();
                Printer.Print(game);



                //  Console.WriteLine(game[0,1]);

                while (!game.End_of_the_game)
                {

                    Console.WriteLine("Enter the value you want to move");
                    start:
                    int value = 0;

                    value = Convert.ToInt32(Console.ReadLine());

                    //      Console.WriteLine("Координаты выбранного элемента до перестановки: {0},{1}", game.GetLocation(value).x, game.GetLocation(value).y);

                    if (value <= 0 || value >= game.Field.Length)
                    {
                        Console.WriteLine("Error: this value doesn't exist");
                        goto start;
                    }


                    if (game.Shift(value) == false)
                    {
                        Console.WriteLine("Error: Change your value, because you can't move it");
                        goto start;
                    }

                    Console.WriteLine("История ходов");

                    for (int i = 0; i < game.History.Count; i++)
                    {
                        Console.Write(game.History[i] + ";");

                    }
                    Console.WriteLine();

                    Printer.Print(game);
                    //   Console.WriteLine("Координаты выбранного элемента после перестановки: {0},{1}", game.GetLocation(value).x, game.GetLocation(value).y);

                    Console.WriteLine("Возможно вы хотите сделать шаг назад ?");

                    ConsoleKeyInfo cki = Console.ReadKey();


                    if (cki.Key == ConsoleKey.LeftArrow)
                    {
                        game.undo();
                    }

                    Console.WriteLine("История ходов");

                    for (int i = 0; i < game.History.Count; i++)
                    {
                        Console.Write(game.History[i] + ";");

                    }
                    Console.WriteLine();

                    Printer.Print(game);
                }
                Console.WriteLine("Game over. You win!");


            }

           
    
                Console.ReadLine();

        }
    }
}
