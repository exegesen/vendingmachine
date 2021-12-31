using System;
using System.Collections.Generic;
namespace vendingmachine
{
    internal class VendingMachine : IVending
    {
        List<Product> products;
        private readonly int[] denominations = { 1, 5, 10, 20, 50, 100, 500, 1000 };
        Dictionary<int, int> sedlar;
        int moneyInMachine;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            VendingMachine v = new VendingMachine();
            v.mainMenu();


        }
        public void mainMenu()
        {
            while (true)
            {
                Console.WriteLine("1 Insert money into vending machine");
                Console.WriteLine("2 Show products");
                Console.WriteLine("3 Purchase product");
                Console.WriteLine("4 End transaction and return money");
                int n = HandleInputAndIntConversion("Valid input: 1 2 3 4");
                switch (n)
                {
                    case 1:
                        Console.WriteLine("Type money amount to input");
                        n = HandleInputAndIntConversion("valid input: 1, 5, 10, 20, 50, 100, 500, 1000 ");
                        this.InsertMoney(n);
                        break;
                    case 2:
                        this.ShowAll();
                        break;
                    case 3:
                        Console.WriteLine("Type product name");
                        String rawinput1 = Console.ReadLine();
                        if (!this.Purchase(rawinput1))
                        {
                            Console.WriteLine("Not enough money");
                        }
                        break;
                    case 4:
                        Dictionary<int, int> d = this.EndTransaction();
                        int val = 0;
                        int totalMoney = 0;
                        Console.Write("1kr ");
                        d.TryGetValue(1, out val);
                        totalMoney += val;
                        Console.WriteLine(val);
                        Console.Write("5kr ");
                        d.TryGetValue(5, out val);
                        totalMoney += val * 5;
                        Console.WriteLine(val);
                        Console.Write("10kr ");
                        d.TryGetValue(10, out val);
                        totalMoney += val * 10;
                        Console.WriteLine(val);
                        Console.Write("20kr ");
                        d.TryGetValue(20, out val);
                        totalMoney += val * 20;
                        Console.WriteLine(val);
                        Console.Write("50kr ");
                        d.TryGetValue(50, out val);
                        totalMoney += val * 50;
                        Console.WriteLine(val);
                        Console.Write("100kr ");
                        d.TryGetValue(100, out val);
                        totalMoney += val * 100;
                        Console.WriteLine(val);
                        Console.Write("500kr ");
                        d.TryGetValue(500, out val);
                        totalMoney += val * 500;
                        Console.WriteLine(val);
                        Console.Write("1000kr ");
                        d.TryGetValue(1000, out val);
                        totalMoney += val * 1000;
                        Console.WriteLine(val);
                        Console.WriteLine(totalMoney);

                        return;
                    default:
                        Console.WriteLine("Invalid input try again!");
                        break;

                }
            }

        }
        private int HandleInputAndIntConversion(String statusmessage)
        {
            String rawinput2 = Console.ReadLine();
            int n1;
            bool correctInput = !Int32.TryParse(rawinput2, out n1);
            while (correctInput)
            {
                Console.WriteLine("Bad input: " + rawinput2 + " " + statusmessage);
                rawinput2 = Console.ReadLine();
                correctInput = !Int32.TryParse(rawinput2, out n1);

            }
            return n1;
        }
        public VendingMachine()
        {
            products = new List<Product>();
            this.sedlar = new Dictionary<int, int>();
            sedlar.Add(1, 0);
            sedlar.Add(5, 0);
            sedlar.Add(10, 0);
            sedlar.Add(20, 0);
            sedlar.Add(50, 0);
            sedlar.Add(100, 0);
            sedlar.Add(500, 0);
            sedlar.Add(1000, 0);
            moneyInMachine = 0;
            Drink cekaCola = new Drink();
            products.Add(cekaCola);
            Drink pekkaCola = new Drink();
            products.Add(pekkaCola);
            Edible merlabouChocklad = new Edible();
            products.Add(merlabouChocklad);
            Alkohol enLilleEn = new Alkohol();
            products.Add(enLilleEn);
            SNUS sNUS = new SNUS();
            products.Add(sNUS);


        }
        public void InsertMoney(int n)
        {
            int getValue = 0;
            switch (n)
            {
                case 1:
                    Console.WriteLine(n + "kr Inserted");
                    sedlar.TryGetValue(1, out getValue);
                    getValue += 1;
                    sedlar.Remove(1);
                    sedlar.Add(1, getValue);
                    this.moneyInMachine += 1;
                    break;
                case 5:
                    Console.WriteLine(n + "kr Inserted");
                    sedlar.TryGetValue(5, out getValue);
                    getValue += 1;
                    sedlar.Remove(10);
                    sedlar.Add(5, getValue);
                    this.moneyInMachine += 5;
                    break;
                case 10:
                    Console.WriteLine(n + "kr Inserted");
                    sedlar.TryGetValue(10, out getValue);
                    getValue += 1;
                    sedlar.Remove(10);
                    sedlar.Add(10, getValue);
                    this.moneyInMachine += 10;
                    break;
                case 20:
                    Console.WriteLine(n + "kr Inserted");
                    sedlar.TryGetValue(20, out getValue);
                    getValue += 1;
                    sedlar.Remove(20);
                    sedlar.Add(20, getValue);
                    this.moneyInMachine += 20;
                    break;
                case 50:
                    Console.WriteLine(n + "kr Inserted");
                    sedlar.TryGetValue(50, out getValue);
                    getValue += 1;
                    sedlar.Remove(50);
                    sedlar.Add(50, getValue);
                    this.moneyInMachine += 50;
                    break;
                case 100:
                    Console.WriteLine(n + "kr Inserted");
                    sedlar.TryGetValue(100, out getValue);
                    getValue += 1;
                    sedlar.Remove(100);
                    sedlar.Add(100, getValue);
                    this.moneyInMachine += 100;
                    break;
                case 500:
                    Console.WriteLine(n + "kr Inserted");
                    sedlar.TryGetValue(500, out getValue);
                    getValue += 1;
                    sedlar.Remove(500);
                    sedlar.Add(500, getValue);
                    this.moneyInMachine += 500;
                    break;
                case 1000:
                    Console.WriteLine(n + "kr Inserted");
                    sedlar.TryGetValue(1000, out getValue);
                    getValue += 1;
                    sedlar.Remove(1000);
                    sedlar.Add(1000, getValue);
                    this.moneyInMachine += 1000;
                    break;
                default:
                    Console.WriteLine("Invalid denomination of currency");
                    break;
            }
        }
        public bool Purchase(String name)
        {

            foreach (Product product in products)
            {
                if (product.getName().ToLower().Equals(name.ToLower()))
                {
                    if (moneyInMachine >= product.getPrice())
                    {

                        this.moneyInMachine -= product.getPrice();
                        Console.WriteLine("Bought " + product.getName());
                        product.Examine();
                        product.Use();

                        return true;
                    }
                    else
                    {

                        return false;
                    }
                }
            }

            return false;
        }

        public void ShowAll()
        {
            Console.WriteLine("Product list: ");
            foreach (Product p in this.products)
            {
                Console.WriteLine(p.getName());
            }
            Console.WriteLine("Product list end.");
        }
        public Dictionary<int, int> EndTransaction()
        {
            this.moneyInMachine = 0;


            return sedlar;

        }

    }
    interface IVending
    {
        public bool Purchase(String name);
        public void ShowAll();
        public void InsertMoney(int n);
        public Dictionary<int, int> EndTransaction();
    }
    abstract class Product
    {
        protected int price;
        protected String name;


        public String getName()
        {
            return this.name;
        }
        public int getPrice()
        {
            return this.price;
        }

        public abstract void Use();
        public virtual void Examine()
        {
            Console.WriteLine(name);
            Console.WriteLine(price + "kr");
        }
    }
    class Edible : Product, IObesityIncreaser
    {
        protected int calories;
        public void EatThis()
        {
            Console.WriteLine("You ate a " + this.name);
        }
        public int getCalories()
        {
            return calories;
        }
        public override void Examine()
        {
            Console.WriteLine(name);
            Console.WriteLine(price + "kr");
            Console.WriteLine(calories + "kcal");
        }

        public override void Use()
        {
            this.EatThis();
        }
    }
    class Drink : Product, IObesityIncreaser
    {
        protected int calories;
        public virtual void DrinkThis()
        {
            Console.WriteLine("You drank a " + this.name);
        }
        public int getCalories()
        {
            return calories;
        }
        public virtual void Examine()
        {
            Console.WriteLine(name);
            Console.WriteLine(price + "kr");
            Console.WriteLine(calories + "kcal");
        }

        public override void Use()
        {
            this.DrinkThis();
        }
    }
    interface IObesityIncreaser
    {
        public int getCalories();
    }
    class Alkohol : Drink, IObesityIncreaser
    {
        protected int alcoholContent;
        public Alkohol()
        {
            this.name = "Generic Alkohol";
            this.price = 100;
            calories = 150;
            alcoholContent = 30;
        }
        public Alkohol(String name)
        {
            this.name = name;
            this.price = 100;
            calories = 150;
            alcoholContent = 30;
        }
        public Alkohol(String name, int price, int alcoholContent, int calories)
        {
            this.name = name;
            this.price = price;
            this.calories = calories;
            this.alcoholContent = alcoholContent;
        }

        public override void Examine()
        {
            Console.WriteLine(name);
            Console.WriteLine(price + "kr");
            Console.WriteLine(calories + "kcal");
            Console.WriteLine(alcoholContent + "%");
        }

        public override void DrinkThis()
        {
            Console.WriteLine("You drank a " + this.name);
            Console.WriteLine("You feel slightly more inebriated.");
        }

        public override void Use()
        {
            DrinkThis();
        }
    }
    class SNUS : Product
    {
        protected int nicotineContent;
        public SNUS()
        {
            this.name = "SNUS";
            this.price = 50;
            nicotineContent = 43; // Siberia har 43 mg/g nikotin
        }

        public override void Examine()
        {
            Console.WriteLine(name);
            Console.WriteLine(price + "kr");

            Console.WriteLine(nicotineContent + "mg/g");
        }

        public void ConsumeThis()
        {
            Console.WriteLine("You put the " + this.name + " under your lip.");
        }

        public override void Use()
        {
            this.ConsumeThis();
        }
    }
}
