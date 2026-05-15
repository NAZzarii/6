using System;

namespace LabClasses
{
    class Freezer
    {
        private string brand;
        private int volume;
        private double currentTemp;
        private bool hasNoFrost;
        private decimal price;

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public int Volume
        {
            get { return volume; }
            set { volume = value; }
        }

        public double CurrentTemp
        {
            get { return currentTemp; }
            set { currentTemp = value; }
        }

        public bool HasNoFrost
        {
            get { return hasNoFrost; }
            set { hasNoFrost = value; }
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        public Freezer() : this("Unknown", 0, 0.0, false, 0)
        {
        }

        public Freezer(string brand, decimal price) : this(brand, 100, -18.5, true, price)
        {
        }

        public Freezer(string brand, int volume, double currentTemp, bool hasNoFrost, decimal price)
        {
            this.brand = brand;
            this.volume = volume;
            this.currentTemp = currentTemp;
            this.hasNoFrost = hasNoFrost;
            this.price = price;
        }

        public override string ToString()
        {
            return $"Морозилка: {brand}, Об'єм: {volume}л, Температура: {currentTemp}C, NoFrost: {hasNoFrost}, Цiна: {price} грн";
        }
    }

    class Program
    {
        static void Main()
        {
            Freezer[] mas = new Freezer[5];

            mas[0] = new Freezer();
            mas[1] = new Freezer("Samsung", 35000);
            mas[2] = new Freezer("LG", 200, -20.0, true, 28000);
            mas[3] = new Freezer("Beko", 150, -15.5, false, 12000);
            mas[4] = new Freezer("Bosch", 45000);

            for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine("Камера №" + (i + 1) + ": " + mas[i].ToString());
            }

            Console.ReadKey();
        }
    }
}
