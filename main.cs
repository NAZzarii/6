using System;

namespace _06_StructClassRefOutParams
{
    class Worker
    {
        private string fullName;
        private int age;
        private decimal salary;
        private DateTime hireDate;

        // Прізвище та ініціали
        public string FullName
        {
            get { return fullName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("ПІБ не може бути порожнім!");

                fullName = value;
            }
        }

        // Вік
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 18 || value > 100)
                    throw new Exception("Некоректний вік!");

                age = value;
            }
        }

        // Зарплата
        public decimal Salary
        {
            get { return salary; }
            set
            {
                if (value < 0)
                    throw new Exception("Зарплата не може бути від'ємною!");

                salary = value;
            }
        }

        // Дата прийняття на роботу
        public DateTime HireDate
        {
            get { return hireDate; }
            set
            {
                if (value > DateTime.Now)
                    throw new Exception("Дата прийняття не може бути в майбутньому!");

                hireDate = value;
            }
        }

        // Метод для обчислення стажу
        public int GetExperience()
        {
            return DateTime.Now.Year - HireDate.Year;
        }

        // Вивід інформації
        public void Print()
        {
            Console.WriteLine($"ПІБ: {FullName}");
            Console.WriteLine($"Вік: {Age}");
            Console.WriteLine($"ЗП: {Salary}");
            Console.WriteLine($"Дата прийняття: {HireDate.ToShortDateString()}");
            Console.WriteLine($"Стаж: {GetExperience()} років");
            Console.WriteLine("--------------------------------");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Worker[] workers = new Worker[5];

            for (int i = 0; i < workers.Length; i++)
            {
                workers[i] = new Worker();

                try
                {
                    Console.WriteLine($"Введення даних працівника #{i + 1}");

                    Console.Write("Введіть прізвище та ініціали: ");
                    workers[i].FullName = Console.ReadLine();

                    Console.Write("Введіть вік: ");
                    workers[i].Age = int.Parse(Console.ReadLine());

                    Console.Write("Введіть зарплату: ");
                    workers[i].Salary = decimal.Parse(Console.ReadLine());

                    Console.Write("Введіть дату прийняття (дд.мм.рррр): ");
                    workers[i].HireDate = DateTime.Parse(Console.ReadLine());

                    Console.WriteLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Помилка: " + ex.Message);
                    i--; // повторне введення
                }
            }

            // Сортування за алфавітом
            Array.Sort(workers, (a, b) => a.FullName.CompareTo(b.FullName));

            Console.Write("Введіть мінімальний стаж: ");
            int minExperience = int.Parse(Console.ReadLine());

            Console.WriteLine("\nПрацівники зі стажем більше заданого:");

            foreach (var worker in workers)
            {
                if (worker.GetExperience() > minExperience)
                {
                    Console.WriteLine(worker.FullName);
                }
            }
        }
    }
}
