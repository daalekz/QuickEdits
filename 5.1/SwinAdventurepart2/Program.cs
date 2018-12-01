using System;

namespace SwinAdventure
{
    class Program
    {
        static Player p;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to SwinAdventure!");
            Console.Write("Please enter your name:\n> ");
            string name = Console.ReadLine();
            Console.Write("Please describe yourself to me:\n> ");
            string desc = Console.ReadLine();

            p = new Player(name, desc);
            Console.WriteLine("Welcome {0}, to the wonderful world of Swinburne!", p.Name);
            p.PlayerInventory.Put(new Item(new string[] { "phone" }, "Phone", "A smartphone that you hardly use the phone features of"));
            Console.WriteLine("You picked up a Phone (phone)! Placed in inventory");
            p.PlayerInventory.Put(new Item(new string[] { "pen" }, "Pen", "A blue ballpoint pen"));
            Console.WriteLine("You picked up a Pen (pen)! Placed in inventory");
            Bag b = new Bag(new string[] { "bag" }, "Bag", "It can hold a variety of things");
            Console.WriteLine("Found a bag!");
            b.BagInventory.Put(new Item(new string[] { "thonkpad" }, "ThonkPad", "One of the finest laptops to grace this earth"));
            Console.WriteLine("You picked up a ThonkPad (thonkpad)! Placed in bag");
            p.PlayerInventory.Put(b);
            Console.WriteLine("Placed Bag (bag) in inventory");

            string input;
            LookCommand cmd = new LookCommand();
            while (true)
            {
                Console.Write("> ");
                input = Console.ReadLine();
                Console.WriteLine(cmd.Execute(p, input.Split(" ")));
            }
        }
    }
}
