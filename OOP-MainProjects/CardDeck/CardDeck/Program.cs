using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardDeck;

namespace CardDeck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            int option = 0;
            do
            {
                header();
                Console.WriteLine("Enter 1 to play the game.");
                Console.WriteLine("Enter 2 to exit the game.");
                Console.WriteLine();
                Console.Write("Your Option: ");
                option = int.Parse(Console.ReadLine());
                
                if (option == 1)
                {
                    bool gameRunning = true;
                    int score = 0;
                    Deck obj = new Deck();
                    obj.shuffle();
                    Card card1 = obj.dealCard();

                    while (gameRunning)
                    {
                        int remain_check = obj.cardsLeft();
                        Card card2 = obj.dealCard();
                        header();
                        Console.WriteLine(card1.ToString());
                        Console.WriteLine("");
                        Console.WriteLine("*** Remaining cards *** : " + remain_check);
                        Console.WriteLine();
                        Console.WriteLine("Enter 1 if the next card is higher.");
                        Console.WriteLine("Enter 2 if the next card is lower.");
                        Console.WriteLine();
                        Console.Write("Your Option: ");
                        int card_check = int.Parse(Console.ReadLine());
                        Console.Clear();
                        if (card_check == 1)
                        {
                            if (card2.getValue() >= card1.getValue())
                            {
                                score++;
                                card1 = card2;
                            }
                            else
                            {
                                header();
                                gameRunning = false;
                                header();
                                Console.WriteLine("The Card was " + card2.toString());
                                Console.WriteLine();
                                Console.WriteLine("You Score is :" + score);
                                Console.WriteLine();
                                Console.WriteLine("SORRY YOU LOSE! PRESS ANY KEY TO CONTINUE ...");
                                Console.ReadKey();
                                Console.Clear();
                            }
                        }

                        if (card_check == 2)
                        {
                            if (card2.getValue() < card1.getValue())
                            {
                                score++;
                                card1 = card2;
                            }
                            else
                            {
                                gameRunning = false;
                                header();
                                Console.WriteLine("The Card was " + card2.toString());
                                Console.WriteLine();
                                Console.WriteLine("You Score is :" + score);
                                Console.WriteLine();
                                Console.WriteLine("SORRY YOU LOSE! PRESS ANY KEY TO CONTINUE ...");
                                Console.ReadKey();
                                Console.Clear();
                            }
                        }
                        if (obj.cardsLeft() == 0 && card2 == null)
                        {
                            gameRunning = false;
                            Console.WriteLine("Congrats you have scored maximum.");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    }
                }
            } while (option != 2);

        }

        public static void header()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("                                              ///////////////////////////////////////////////////////////////////");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("                                              //                           CARD DECK                           //");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("                                              ///////////////////////////////////////////////////////////////////");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine();
        }

    }
}