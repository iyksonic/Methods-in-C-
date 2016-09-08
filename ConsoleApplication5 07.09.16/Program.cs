using System;

namespace ConsoleApplication5_07._09._16
{
    class Program
    {
        static void Main(string[] args)
        {
            doVerse(1);
            doChrous();
            doVerse(2);
            doChrous();

            Console.ReadLine();
        }

        static void doChrous()
        {
            string message = "";
            message += "\n\n ...With a knick-knack paddy whack";
            message += "\n Give a dog a bone";
            message += "\n This old man came rolling home\n\n";
           
            Console.WriteLine(message);
        }
        static void doVerse(int verseNum)
        {
            string message = "";
            message += "\n.. This old man, he played";
            message += verseNum;
            message += "\n He played knick-knack";
            message += getPlace(verseNum);
            Console.WriteLine(message);
        }

        
        static string getPlace(int verseNum)
        {
            string message = "";
            
            switch (verseNum)
            {
                case 1:
                    message = "On my thumb";
                    break;
                case 2:
                    message = "On my shoe";
                    break;
                default:
                    message = "not defined";
                    break;
            }
            return message;
        }
    }
}
