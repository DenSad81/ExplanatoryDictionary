using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, string> dictionary = new Dictionary<string, string>
            {
                 {"a","device for heat dissipation"},
                 {"bb","connection device" },
                 {"ccc","clamping device"},
                 {"dddd","electronic component"}
            };
        string wordFromUser;
        int memoriPositionCursorLeft;
        int memoriPositionCursorTop;
        bool isRun = true;
        string commandExit = "exit";

        while (isRun)
        {
            Console.Write("Input a word (or command exit): ");
            memoriPositionCursorLeft = Console.CursorLeft;
            memoriPositionCursorTop = Console.CursorTop;
            wordFromUser = Console.ReadLine();

            if (dictionary.ContainsKey(wordFromUser))
            {
                Console.SetCursorPosition(memoriPositionCursorLeft + wordFromUser.Length, memoriPositionCursorTop);
                Console.Write("   " + dictionary[wordFromUser]);
                Console.WriteLine();
            }
            else
            {
                Console.SetCursorPosition(memoriPositionCursorLeft + wordFromUser.Length, memoriPositionCursorTop);
                Console.WriteLine("   " + "This word is not presents");
            }

            if (wordFromUser == commandExit)
            {
                isRun = false;
            }
        }
    }
}