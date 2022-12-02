// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using DependencyInjectionTest;


IDrink drink1 = new Drink1();
Barman barman = new Barman(drink1);
barman.PrepareDrink();

IDrink drink2 = new Drink2("spicy");
barman = new Barman(drink2);
barman.PrepareDrink();