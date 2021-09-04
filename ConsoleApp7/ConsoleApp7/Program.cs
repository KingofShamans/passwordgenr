using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите уровень сложность(легкий, средний, сложный)");
            string level = Convert.ToString(Console.ReadLine());
            switch (level)
                {

                case "легкий":
                    string iPass = "";
                    string[] arr = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "B", "C", "D", "F", "G", "H", "J", "K", "L", "M", "N", "P", "Q", "R", "S", "T", "V", "W", "X", "Z", "b", "c", "d", "f", "g", "h", "j", "k", "m", "n", "p", "q", "r", "s", "t", "v", "w", "x", "z", "A", "E", "U", "Y", "a", "e", "i", "o", "u", "y" };
                    Random rnd = new Random();
                    for (int i = 0; i < 8; i = i + 1)
                    {
                        iPass = iPass + arr[rnd.Next(0, 57)];
                    }
                    Console.WriteLine(iPass);
                    break;

                case "средний":
                    string iPass1 = "";
                    string[] arr1 = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "B", "C", "D", "F", "G", "H", "J", "K", "L", "M", "N", "P", "Q", "R", "S", "T", "V", "W", "X", "Z", "b", "c", "d", "f", "g", "h", "j", "k", "m", "n", "p", "q", "r", "s", "t", "v", "w", "x", "z", "A", "E", "U", "Y", "a", "e", "i", "o", "u", "y" };
                    Random rnd1 = new Random();
                    for (int i = 0; i < 16; i = i + 1)
                    {
                        iPass1 = iPass1 + arr1[rnd1.Next(0, 57)];
                    }
                    Console.WriteLine(iPass1);

                    break;

                case "сложный":
                    string iPass2 = "";
                    string[] arr2 = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "B", "C", "D", "F", "G", "H", "J", "K", "L", "M", "N", "P", "Q", "R", "S", "T", "V", "W", "X", "Z", "b", "c", "d", "f", "g", "h", "j", "k", "m", "n", "p", "q", "r", "s", "t", "v", "w", "x", "z", "A", "E", "U", "Y", "a", "e", "i", "o", "u", "y" };
                    Random rnd2 = new Random();
                    for (int i = 0; i < 20; i = i + 1)
                    {
                        iPass2 = iPass2 + arr2[rnd2.Next(0, 57)];
                    }
                    Console.WriteLine(iPass2);

                    break;

                default:
                    Console.WriteLine("Пока");
                    break;

            }
            
        }
    }
}
