using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpcs02
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorld();
            Echo();
            Reverse();
            Triforce();
            QCM("quelle est la difference entre un pigeon ?", "Les deux pattes, surtout la gauche", "Oui", "Obiwan Kenobi", "La reponse D", 2);
            Morse();

            Console.Read();

        }
        public static void HelloWorld()
        {
            Console.WriteLine("Hello World");

        }
        static void Echo()
        {
            string texte = Console.ReadLine();
            Console.WriteLine(texte);
        }
        static void Reverse()
        {
            string ligne = "";
            string reverse = "";
            ligne = System.Console.ReadLine();
            for (int i = ligne.Length - 1; i >= 0; i--)
            {
                reverse += ligne[i];
            }
            System.Console.WriteLine(reverse);
        }
        static void Triforce()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("/\\              \n           /__\\       \n" + "          /\\  /\\       \n" + "         /__\\/__\\      \n");
            Console.ResetColor();


        }

        static void QCM(string question, string ans1, string ans2, string ans3, string ans4, int answer)
        {
            Console.WriteLine(question);
            Console.WriteLine("1)" + ans1);
            Console.WriteLine("2)" + ans2);
            Console.WriteLine("3)" + ans3);
            Console.WriteLine("4)" + ans4);
            string reponse = Console.ReadLine();
            if (Convert.ToInt32(reponse) == answer)
            {
                Console.WriteLine("Good job bro!");
            }
            else if (Convert.ToInt32(reponse) > 4)
            {
                Console.WriteLine("So counting is too hard, n00b...");

            }
            else
            {
                Console.WriteLine("You loose... The answer was" + answer);
            }


        }
        static void Morse()
        {
            string phrase = Console.ReadLine();
            for (int i = phrase.Length - 1; i >= 0; i--)
                if (phrase[i] == '_')
                {
                    Console.Beep(900, 450);
                }
                else
                {
                    if (phrase[i] == '.')
                    {
                        Console.Beep(900, 150);
                    }
                    else
                    {
                        if (phrase[i] == ' ')
                        {
                            System.Threading.Thread.Sleep(450);
                        }
                        else
                        {
                            System.Console.WriteLine("Only '_', '.' or ' '");
                        }


                    }

                }
        }
    }
}
