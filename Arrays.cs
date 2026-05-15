using System;

class Program
{
    static void Main()
    {
        // Завдання 1
        int[] mas = { 1, 5, 8, 2, 5, 10, 3, 8, 4 };
        int parni = 0;
        int neparni = 0;
        int unikalni = 0;

        for (int i = 0; i < mas.Length; i++)
        {
            if (mas[i] % 2 == 0)
            {
                parni++;
            }
            else
            {
                neparni++;
            }

            int count = 0;
            for (int j = 0; j < mas.Length; j++)
            {
                if (mas[i] == mas[j])
                {
                    count++;
                }
            }
            if (count == 1)
            {
                unikalni++;
            }
        }

        Console.WriteLine("Кількість парних: " + parni);
        Console.WriteLine("Кількість непарних: " + neparni);
        Console.WriteLine("Кількість унікальних: " + unikalni);

        Console.WriteLine("---------------------------");

        // Завдання 2
        Console.Write("Введіть число для порівняння: ");
        int limit = int.Parse(Console.ReadLine());
        int menshi = 0;

        for (int i = 0; i < mas.Length; i++)
        {
            if (mas[i] < limit)
            {
                menshi++;
            }
        }

        Console.WriteLine("Кількість елементів менших за " + limit + ": " + menshi);
        
        Console.ReadKey();
    }
}
