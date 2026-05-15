using System;

class Program
{
    static void Main()
    {
        // Завдання 3
        double[] A = new double[5];
        double[,] B = new double[3, 4];
        Random rnd = new Random();

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Введiть елемент A[" + i + "]: ");
            A[i] = double.Parse(Console.ReadLine());
        }

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                B[i, j] = Math.Round(rnd.NextDouble() * 100, 1);
            }
        }

        Console.WriteLine("\nМасив A:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write(A[i] + " ");
        }

        Console.WriteLine("\n\nМасив B:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write(B[i, j] + "\t");
            }
            Console.WriteLine();
        }

        double max = A[0];
        double min = A[0];
        double sumaZahal = 0;
        double dobutokZahal = 1;

        for (int i = 0; i < 5; i++)
        {
            if (A[i] > max) max = A[i];
            if (A[i] < min) min = A[i];
            sumaZahal += A[i];
            dobutokZahal *= A[i];
        }

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                if (B[i, j] > max) max = B[i, j];
                if (B[i, j] < min) min = B[i, j];
                sumaZahal += B[i, j];
                dobutokZahal *= B[i, j];
            }
        }

        double sumParniA = 0;
        for (int i = 0; i < 5; i++)
        {
            if (A[i] % 2 == 0) sumParniA += A[i];
        }

        double sumNeparniStovpB = 0;
        for (int j = 0; j < 4; j++)
        {
            if ((j + 1) % 2 != 0) 
            {
                for (int i = 0; i < 3; i++)
                {
                    sumNeparniStovpB += B[i, j];
                }
            }
        }

        Console.WriteLine("\nMax: " + max);
        Console.WriteLine("Min: " + min);
        Console.WriteLine("Suma: " + sumaZahal);
        Console.WriteLine("Dobutok: " + dobutokZahal);
        Console.WriteLine("Suma parnih A: " + sumParniA);
        Console.WriteLine("Suma neparnih stovpciv B: " + sumNeparniStovpB);

        Console.WriteLine("\n--- Завдання 4 ---");
        int[,] matrix = new int[5, 5];
        int max4 = -101, min4 = 101;
        int maxI = 0, maxJ = 0, minI = 0, minJ = 0;

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                matrix[i, j] = rnd.Next(-100, 101);
                Console.Write(matrix[i, j] + "\t");
                if (matrix[i, j] > max4) { max4 = matrix[i, j]; maxI = i; maxJ = j; }
                if (matrix[i, j] < min4) { min4 = matrix[i, j]; minI = i; minJ = j; }
            }
            Console.WriteLine();
        }

        int start = minI * 5 + minJ;
        int end = maxI * 5 + maxJ;
        if (start > end) { int temp = start; start = end; end = temp; }

        int sumaMizh = 0;
        for (int k = start + 1; k < end; k++)
        {
            sumaMizh += matrix[k / 5, k % 5];
        }
        Console.WriteLine("Suma mizh min i max: " + sumaMizh);

        Console.WriteLine("\n--- Завдання 5 ---");
        int[] mas5 = { 10, 5, 15, 20, 10, 7, 5 };
        int min5 = mas5[0];
        for (int i = 1; i < mas5.Length; i++)
        {
            if (mas5[i] < min5) min5 = mas5[i];
        }

        int count5 = 0;
        for (int i = 0; i < mas5.Length; i++)
        {
            if (Math.Abs(mas5[i] - min5) == 5) count5++;
        }
        Console.WriteLine("Kilkist elementiv (vidrizn. na 5 vid min): " + count5);

        Console.ReadKey();
    }
}
