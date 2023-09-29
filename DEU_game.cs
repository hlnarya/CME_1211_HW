using System;
using System.Threading;
namespace DEUGAME
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arrayA1 = new char[15];
            char[] arrayA2 = new char[15];
            char[] arrayA3 = new char[15];
            char[] DEURND = new char[3] { 'D', 'E', 'U' }; // Valid Chars for RND
            int i = 0, j = 0, RNDCHAR, whicharr; //temporary intigers needed for loops and RND , //j is for avoiding repeated result in scoreboard
            int p1sc = 120, p2sc = 120; //Player Score
            int arrA1pos = 0, arrA2pos = 0, arrA3pos = 0; // position of the letter in each line
            bool arr15cnt = false; // Controls that the letter is putted in the correct place
            int winner = 0; //winner control
            string[] names = new string[12] { "Derya", "Elife", "Fatih", "Ali", "Azra", "Sibel", "Cem", "Nazan", "Mehmet", "Nil", "Can", "Tarkan" }; //Default scoreboard
            int[] scores = { 100, 100, 95, 90, 85, 80, 80, 70, 55, 50, 30, 30 };//Default scoreboard
            do // Repeats creating new chars untile there is a winner or tie
            {
                Random rand = new Random();
                RNDCHAR = rand.Next(DEURND.Length);
                do // tries matching RND chars to valid positions
                {
                    whicharr = rand.Next(1, 4);
                    switch (whicharr) //randomises the line which new char would be in
                    {
                        case 1:
                            if (arrA1pos <= 14)
                            {
                                arrayA1[arrA1pos] = DEURND[RNDCHAR]; //puting RND char to a RND array
                                arr15cnt = false;
                                if (arrA1pos >= 2) //controling win conditions after adding the valid char
                                {
                                    if (arrayA1[arrA1pos] == 'U')
                                    {
                                        if (arrayA1[arrA1pos - 1] == 'E')
                                        {
                                            if (arrayA1[arrA1pos - 2] == 'D')
                                            {
                                                if (i % 2 == 0)
                                                {
                                                    winner = 1;
                                                }
                                                else
                                                    winner = 2;
                                            }
                                        }
                                        else if (arrayA2[arrA1pos] == 'E')
                                        {
                                            if (arrayA3[arrA1pos] == 'D')
                                            {
                                                if (i % 2 == 0)
                                                {
                                                    winner = 1;
                                                }
                                                else
                                                    winner = 2;
                                            }
                                        }
                                        else if (arrayA2[arrA1pos - 1] == 'E')
                                        {
                                            if (arrayA3[arrA1pos - 2] == 'D')
                                            {
                                                if (i % 2 == 0)
                                                {
                                                    winner = 1;
                                                }
                                                else
                                                    winner = 2;
                                            }
                                        }
                                        else if (arrA1pos <= 12)
                                        {
                                            if (arrayA2[arrA1pos + 1] == 'E')
                                            {
                                                if (arrayA3[arrA1pos + 2] == 'D')
                                                {
                                                    if (i % 2 == 0)
                                                    {
                                                        winner = 1;
                                                    }
                                                    else
                                                        winner = 2;
                                                }
                                            }
                                        }

                                    }
                                    else if (arrayA1[arrA1pos] == 'D')
                                    {
                                        if (arrayA1[arrA1pos - 1] == 'E')
                                        {
                                            if (arrayA1[arrA1pos - 2] == 'U')
                                            {
                                                if (i % 2 == 0)
                                                {
                                                    winner = 1;
                                                }
                                                else
                                                    winner = 2;
                                            }
                                        }
                                        else if (arrayA2[arrA1pos] == 'E')
                                        {
                                            if (arrayA3[arrA1pos] == 'U')
                                            {
                                                if (i % 2 == 0)
                                                {
                                                    winner = 1;
                                                }
                                                else
                                                    winner = 2;
                                            }
                                        }
                                        else if (arrayA2[arrA1pos - 1] == 'E')
                                        {
                                            if (arrayA3[arrA1pos - 2] == 'U')
                                            {
                                                if (i % 2 == 0)
                                                {
                                                    winner = 1;
                                                }
                                                else
                                                    winner = 2;
                                            }
                                        }
                                        else if (arrA1pos <= 12)
                                        {
                                            if (arrayA2[arrA1pos + 1] == 'E')
                                            {
                                                if (arrayA3[arrA1pos + 2] == 'U')
                                                {
                                                    if (i % 2 == 0)
                                                    {
                                                        winner = 1;
                                                    }
                                                    else
                                                        winner = 2;
                                                }
                                            }
                                        }


                                    }

                                }
                                else if (arrA1pos < 2)
                                {
                                    if (arrayA1[arrA1pos] == 'U')
                                    {
                                        if (arrayA2[arrA1pos] == 'E')
                                        {
                                            if (arrayA3[arrA1pos] == 'D')
                                            {
                                                if (i % 2 == 0)
                                                {
                                                    winner = 1;
                                                }
                                                else
                                                    winner = 2;
                                            }
                                        }
                                    }
                                    else if (arrayA1[arrA1pos] == 'D')
                                    {
                                        if (arrayA2[arrA1pos] == 'E')
                                        {
                                            if (arrayA3[arrA1pos] == 'U')
                                            {
                                                if (i % 2 == 0)
                                                {
                                                    winner = 1;
                                                }
                                                else
                                                    winner = 2;
                                            }
                                        }
                                    }

                                }
                                arrA1pos++;
                            }
                            else arr15cnt = true;

                            break;
                        case 2:
                            if (arrA2pos <= 14)
                            {
                                arrayA2[arrA2pos] = DEURND[RNDCHAR];//puting RND char to a RND array
                                arr15cnt = false;
                                if (arrA2pos >= 2)//controling win conditions after adding the valid char
                                {
                                    if (arrayA2[arrA2pos] == 'U')
                                    {
                                        if (arrayA2[arrA2pos - 1] == 'E')
                                        {
                                            if (arrayA2[arrA2pos - 2] == 'D')
                                            {
                                                if (i % 2 == 0)
                                                {
                                                    winner = 1;
                                                }
                                                else
                                                    winner = 2;
                                            }
                                        }

                                    }
                                    else if (arrayA2[arrA2pos] == 'D')
                                    {
                                        if (arrayA2[arrA2pos - 1] == 'E')
                                        {
                                            if (arrayA2[arrA2pos - 2] == 'U')
                                            {
                                                if (i % 2 == 0)
                                                {
                                                    winner = 1;
                                                }
                                                else
                                                    winner = 2;
                                            }
                                        }


                                    }
                                    else if (arrayA2[arrA2pos] == 'E')
                                    {
                                        if (arrA2pos <= 13)
                                        {
                                            if (arrayA1[arrA2pos + 1] == 'D')
                                            {
                                                if (arrayA3[arrA2pos - 1] == 'U')
                                                {
                                                    if (i % 2 == 0)
                                                    {
                                                        winner = 1;
                                                    }
                                                    else
                                                        winner = 2;
                                                }
                                            }
                                            else if (arrayA1[arrA2pos - 1] == 'D')
                                            {
                                                if (arrayA3[arrA2pos + 1] == 'U')
                                                {
                                                    if (i % 2 == 0)
                                                    {
                                                        winner = 1;
                                                    }
                                                    else
                                                        winner = 2;
                                                }
                                            }
                                            else if (arrayA1[arrA2pos - 1] == 'U')
                                            {
                                                if (arrayA3[arrA2pos + 1] == 'D')
                                                {
                                                    if (i % 2 == 0)
                                                    {
                                                        winner = 1;
                                                    }
                                                    else
                                                        winner = 2;
                                                }
                                            }
                                            else if (arrayA1[arrA2pos + 1] == 'U')
                                            {
                                                if (arrayA3[arrA2pos - 1] == 'D')
                                                {
                                                    if (i % 2 == 0)
                                                    {
                                                        winner = 1;
                                                    }
                                                    else
                                                        winner = 2;
                                                }
                                            }
                                        }
                                        if (arrayA1[arrA2pos] == 'D')
                                        {
                                            if (arrayA3[arrA2pos] == 'U')
                                            {
                                                if (i % 2 == 0)
                                                {
                                                    winner = 1;
                                                }
                                                else
                                                    winner = 2;
                                            }
                                        }
                                        else if (arrayA1[arrA2pos] == 'U')
                                        {
                                            if (arrayA3[arrA2pos] == 'D')
                                            {
                                                if (i % 2 == 0)
                                                {
                                                    winner = 1;
                                                }
                                                else
                                                    winner = 2;
                                            }
                                        }
                                    }

                                }
                                else if (arrA2pos < 2)
                                {
                                    if (arrayA1[arrA2pos] == 'U')
                                    {
                                        if (arrayA2[arrA2pos] == 'E')
                                        {
                                            if (arrayA3[arrA2pos] == 'D')
                                            {
                                                if (i % 2 == 0)
                                                {
                                                    winner = 1;
                                                }
                                                else
                                                    winner = 2;
                                            }
                                        }
                                    }
                                    else if (arrayA1[arrA2pos] == 'D')
                                    {
                                        if (arrayA2[arrA2pos] == 'E')
                                        {
                                            if (arrayA3[arrA2pos] == 'U')
                                            {
                                                if (i % 2 == 0)
                                                {
                                                    winner = 1;
                                                }
                                                else
                                                    winner = 2;
                                            }
                                        }
                                    }

                                }

                                arrA2pos++;
                            }
                            else arr15cnt = true;

                            break;
                        case 3:
                            if (arrA3pos <= 14)
                            {
                                arrayA3[arrA3pos] = DEURND[RNDCHAR];//puting RND char to a RND array
                                arr15cnt = false;
                                if (arrA3pos >= 2)//controling win conditions after adding the valid char
                                {
                                    if (arrayA3[arrA3pos] == 'U')
                                    {
                                        if (arrayA3[arrA3pos - 1] == 'E')
                                        {
                                            if (arrayA3[arrA3pos - 2] == 'D')
                                            {
                                                if (i % 2 == 0)
                                                {
                                                    winner = 1;
                                                }
                                                else
                                                    winner = 2;
                                            }
                                        }
                                        else if (arrayA2[arrA3pos] == 'E')
                                        {
                                            if (arrayA1[arrA3pos] == 'D')
                                            {
                                                if (i % 2 == 0)
                                                {
                                                    winner = 1;
                                                }
                                                else
                                                    winner = 2;
                                            }
                                        }
                                        else if (arrayA2[arrA3pos - 1] == 'E')
                                        {
                                            if (arrayA1[arrA3pos - 2] == 'D')
                                            {
                                                if (i % 2 == 0)
                                                {
                                                    winner = 1;
                                                }
                                                else
                                                    winner = 2;
                                            }
                                        }
                                        else if (arrA3pos <= 12)
                                        {
                                            if (arrayA2[arrA3pos + 1] == 'E')
                                            {
                                                if (arrayA1[arrA3pos + 2] == 'D')
                                                {
                                                    if (i % 2 == 0)
                                                    {
                                                        winner = 1;
                                                    }
                                                    else
                                                        winner = 2;
                                                }
                                            }
                                        }

                                    }
                                    else if (arrayA3[arrA3pos] == 'D')
                                    {
                                        if (arrayA3[arrA3pos - 1] == 'E')
                                        {
                                            if (arrayA3[arrA3pos - 2] == 'U')
                                            {
                                                if (i % 2 == 0)
                                                {
                                                    winner = 1;
                                                }
                                                else
                                                    winner = 2;
                                            }
                                        }
                                        else if (arrayA2[arrA3pos] == 'E')
                                        {
                                            if (arrayA1[arrA3pos] == 'U')
                                            {
                                                if (i % 2 == 0)
                                                {
                                                    winner = 1;
                                                }
                                                else
                                                    winner = 2;
                                            }
                                        }
                                        else if (arrayA2[arrA3pos - 1] == 'E')
                                        {
                                            if (arrayA1[arrA3pos - 2] == 'U')
                                            {
                                                if (i % 2 == 0)
                                                {
                                                    winner = 1;
                                                }
                                                else
                                                    winner = 2;
                                            }
                                        }
                                        else if (arrA3pos <= 12)
                                        {
                                            if (arrayA2[arrA3pos + 1] == 'E')
                                            {
                                                if (arrayA1[arrA3pos + 2] == 'U')
                                                {
                                                    if (i % 2 == 0)
                                                    {
                                                        winner = 1;
                                                    }
                                                    else
                                                        winner = 2;
                                                }
                                            }
                                        }


                                    }

                                }

                                arrA3pos++;
                            }
                            else arr15cnt = true;

                            break;
                    }
                } while (arr15cnt == true);


                if (i % 2 == 0) //checking whose turn is it
                {
                    p1sc = p1sc - 5;



                    Console.Write("\n\nPlayer1:    (P1-" + p1sc + "  P2-" + p2sc + ")\n"); //writing scoreboard
                    Console.Write("A1  ");
                    Array.ForEach(arrayA1, Console.Write);
                    Console.Write("\nA2  ");
                    Array.ForEach(arrayA2, Console.Write);
                    Console.Write("\nA3  ");
                    Array.ForEach(arrayA3, Console.Write);
                    if (winner == 1)
                    {
                        Console.WriteLine("\nwinner: Plyer1\n");
                        Console.WriteLine("\nName\tScore");
                        for (int m = 0; m <= 11; m++)
                        {
                            if (p1sc < scores[11])
                            {
                                Console.Write("Player1");
                                Console.Write("\t" + p1sc + "\n");
                            }
                            else if (p1sc > scores[m] && j == 0)
                            {
                                Console.Write("Player1");
                                Console.Write("\t" + p1sc + "\n");
                                j = 1;
                            }
                            Console.Write(names[m]);
                            Console.Write("\t" + scores[m] + "\n");
                            if (p1sc == scores[m] && j == 0)
                            {
                                Console.Write("Player1");
                                Console.Write("\t" + p1sc + "\n");
                                j = 1;
                            }

                        }




                    }

                }
                else
                {
                    p2sc = p2sc - 5;



                    Console.Write("\n\nPlayer2:    (P1-" + p1sc + "  P2-" + p2sc + ")\n"); //writing scoreboard
                    Console.Write("A1  ");
                    Array.ForEach(arrayA1, Console.Write);
                    Console.Write("\nA2  ");
                    Array.ForEach(arrayA2, Console.Write);
                    Console.Write("\nA3  ");
                    Array.ForEach(arrayA3, Console.Write);
                    if (winner == 2)
                    {
                        Console.WriteLine("\nwinner: Plyer2\n");
                        Console.WriteLine("\nName\tScore");
                        for (int m = 0; m <= 11; m++)
                        {
                            if (p2sc < scores[11])
                            {
                                Console.Write("Player2");
                                Console.Write("\t" + p2sc + "\n");
                            }
                            else if (p2sc > scores[m] && j == 0)
                            {
                                Console.Write("Player2");
                                Console.Write("\t" + p2sc + "\n");
                                j = 1;
                            }
                            Console.Write(names[m]);
                            Console.Write("\t" + scores[m] + "\n");
                            if (p2sc == scores[m] && j == 0)
                            {
                                Console.Write("Player2");
                                Console.Write("\t" + p2sc + "\n");
                                j = 1;
                            }

                        }




                    }
                }
                i++;
                if (i == 45 && winner == 0)
                {
                    Console.Write("\nTie\n");
                    for (int m = 0; m <= 11; m++)
                    {

                        Console.Write(names[m]);
                        Console.Write("\t" + scores[m] + "\n");

                    }


                }
                Thread.Sleep(1500); //sleep 1500ms


            } while (winner == 0 && i <= 45);
            Console.ReadKey();
        }

    }
}
