using System;
using System.Globalization;

namespace RandomNumberGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("░▒█▀▀▄░█▀▀▄░█▀▀▄░█▀▄░▄▀▀▄░█▀▄▀█░░░▒█▄░▒█░█░▒█░█▀▄▀█░█▀▀▄░█▀▀░█▀▀▄░░░▒█▀▀█░█▀▀░█▀▀▄░█▀▀░█▀▀▄░█▀▀▄░▀█▀░▄▀▀▄░█▀▀▄\r\n░▒█▄▄▀░█▄▄█░█░▒█░█░█░█░░█░█░▀░█░░░▒█▒█▒█░█░▒█░█░▀░█░█▀▀▄░█▀▀░█▄▄▀░░░▒█░▄▄░█▀▀░█░▒█░█▀▀░█▄▄▀░█▄▄█░░█░░█░░█░█▄▄▀\r\n░▒█░▒█░▀░░▀░▀░░▀░▀▀░░░▀▀░░▀░░▒▀░░░▒█░░▀█░░▀▀▀░▀░░▒▀░▀▀▀▀░▀▀▀░▀░▀▀░░░▒█▄▄▀░▀▀▀░▀░░▀░▀▀▀░▀░▀▀░▀░░▀░░▀░░░▀▀░░▀░▀▀\r\n");
            Console.WriteLine("");
            bool Antwort = false;
            bool anfang = false;


            Console.WriteLine("Hallo, möchtest du ein Ratespiel spielen? [True/False]");

            while (!anfang)
                try
                {


                    Antwort=Convert.ToBoolean(Console.ReadLine());
                    anfang = true;
                }
                catch
                {
                    Console.WriteLine("Du musst mit True=Ja oder False=Nein antworten!");
                }
            if (Antwort)
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Okey, ich habe eine zufällige Zahl zwischen 1-100 generiert.");
                Console.WriteLine("Versuche sie zu erraten in dem du eine ganze Zahl eingibst.");
                Console.WriteLine("Ich werde dir mit Tipps helfen:)");
                Console.WriteLine("");

               //NumberGen#1 für iene Zahl zwischen 1 und 101
                
                Random rnd = new Random();
                int rndNum = rnd.Next(1, 101);
                int i = 0;
                bool resultFound = false;
                bool Gewonnen = false;

                while (!Gewonnen)
                {

                    while (!resultFound)
                    {
                        int num = 0;

                        try
                        {
                            Console.Write("Zahl:");
                            num = int.Parse(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("Deine eingegebende Zahl ist keine Ganzahl!");

                            Console.WriteLine("------------------------------------------");
                            Main(args);
                            break;

                        }


                        if (num > rndNum)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Die gesuchte Zahl ist tiefer");
                            i++;
                            Console.WriteLine("------------------------------------------");
                            Console.ResetColor();
                        }

                        else if (num < rndNum)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Die gesuchte Zahl ist höher");
                            i++;
                            Console.WriteLine("------------------------------------------");
                            Console.ResetColor();
                        }

                        else if (Antwort == false)
                        {
                            Console.WriteLine("Schade Marmelade ");

                        }

                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("Super! Du hast die gesuchte Zahl in ");
                            Console.Write(i);
                            Console.Write(" Versuchen gefunden");
                            Console.ResetColor();
                            resultFound = true;
                            i++;


                        }
                    }
                }    
                    
                //NumberGen#2 für Zahl zwischen 1 und 1001
                    Random rnd2 = new Random();
                    int rndNum2 = rnd2.Next(1, 1001);
                    int y = 0;
                    bool resultFound2 = false;

                    while (!resultFound)
                    {
                        int num2 = 0;

                        try
                        {
                            Console.Write("Zahl:");
                            num2 = int.Parse(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("Deine eingegebende Zahl ist keine Ganzahl!");

                            Console.WriteLine("------------------------------------------");
                            Main(args);
                            break;

                        }


                        if (num2 > rndNum2)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Die gesuchte Zahl ist tiefer");
                            y++;
                            Console.WriteLine("------------------------------------------");
                            Console.ResetColor();
                        }

                        else if (num2 < rndNum2)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Die gesuchte Zahl ist höher");
                            y++;
                           
                            Console.WriteLine("------------------------------------------");
                            Console.ResetColor();
                        }

                        else if (Antwort == false)
                        {
                            Console.WriteLine("Schade Marmelade ");

                        }

                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("Super! Du hast die gesuchte Zahl in ");
                            Console.Write(y);
                            Console.Write(" Versuchen gefunden");
                            Console.ResetColor();
                            resultFound2 = true;
                            y++;


                        }





                    }



                }
            }
        }
    }
