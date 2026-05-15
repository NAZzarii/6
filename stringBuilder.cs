using System;
using System.Text;

class Program
{
    static void Main()
    {
        // Завдання 1
        string s1 = "Програмування це круто";
        string s2 = "дуже ";
        s1 = s1.Insert(15, s2);
        Console.WriteLine("Завдання 1: " + s1);

        // Завдання 2
        Console.Write("\nВведiть слово для перевiрки на палiндром: ");
        string pal = Console.ReadLine();
        string rev = "";
        for (int i = pal.Length - 1; i >= 0; i--)
        {
            rev += pal[i];
        }
        if (pal.ToLower() == rev.ToLower()) Console.WriteLine("Це палiндром");
        else Console.WriteLine("Це не палiндром");

        // Завдання 3
        string text3 = "Привiт, як Справи? Тест 123.";
        int mali = 0;
        int velyki = 0;
        int vsogo = text3.Length;

        for (int i = 0; i < vsogo; i++)
        {
            if (char.IsLower(text3[i])) mali++;
            else if (char.IsUpper(text3[i])) velyki++;
        }

        double vidsotokMali = (double)mali / vsogo * 100;
        double vidsotokVelyki = (double)velyki / vsogo * 100;
        Console.WriteLine("\nЗавдання 3:");
        Console.WriteLine("Малих лiтер: " + vidsotokMali + "%");
        Console.WriteLine("Великих лiтер: " + vidsotokVelyki + "%");

        // Завдання 4
        string[] slova = { "собака", "кiт", "молоко", "вода", "школа" };
        int potribnaDovzhyna = 5;
        Console.WriteLine("\nЗавдання 4:");
        for (int i = 0; i < slova.Length; i++)
        {
            if (slova[i].Length == potribnaDovzhyna)
            {
                slova[i] = slova[i].Substring(0, slova[i].Length - 3) + "$";
            }
            Console.Write(slova[i] + " ");
        }
        Console.WriteLine();

        // Завдання 5
        string text5 = "я люблю писати код на шарпах";
        int n = 4;
        string[] mas5 = text5.Split(' ');
        if (n <= mas5.Length)
        {
            string word = mas5[n - 1];
            Console.WriteLine("\nЗавдання 5: Перша буква " + n + "-го слова: " + word[0]);
        }

        // Завдання 6
        string text6 = "   багато   пробiлiв   на  початку i в кiнцi   ";
        string[] chyste = text6.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string rez6 = string.Join("*", chyste);
        Console.WriteLine("\nЗавдання 6: " + rez6);

        // Завдання 7
        Console.WriteLine("\nЗавдання 7 (вводьте слова, в кiнцi останнього поставте крапку):");
        StringBuilder sb = new StringBuilder();
        while (true)
        {
            string vvid = Console.ReadLine();
            
            if (sb.Length > 0)
            {
                sb.Append(", ");
            }

            if (vvid.EndsWith("."))
            {
                sb.Append(vvid);
                break;
            }
            else
            {
                sb.Append(vvid);
            }
        }
        Console.WriteLine("Результат: " + sb.ToString());

        Console.ReadKey();
    }
}
