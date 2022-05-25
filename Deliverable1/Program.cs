// See https://aka.ms/new-console-template for more information

bool restart = true;

while (restart == true) {
    Console.WriteLine("How many people are we making PB&J sandwiches for? Enter number:");
    int people = int.Parse(Console.ReadLine());

    double slicesNeeded = 2 * people;
    double spoonsPBNeeded = 2 * people;
    double spoonsJellyNeeded = 4 * people;

    Console.WriteLine("You need:");
    Console.WriteLine(slicesNeeded + " slices of bread");
    Console.WriteLine(spoonsPBNeeded + " tablespoons of peanutbutter");
    Console.WriteLine(spoonsJellyNeeded + " teaspoons of jelly");
    Console.WriteLine("");
    Console.WriteLine("Which is...");

    double slicesPerLoaf = 28;
    double spoonsPerJarPB = 32;
    double spoonsPerJarJelly = 48;

    double totalLoavesNeeded = Math.Ceiling(slicesNeeded / slicesPerLoaf);
    double totalJarsPBNeeded = Math.Ceiling(spoonsPBNeeded / spoonsPerJarPB);
    double totalJarsJellyNeeded = Math.Ceiling(spoonsJellyNeeded / spoonsPerJarJelly);

    Console.WriteLine(totalLoavesNeeded + " loaf(s) of bread");
    Console.WriteLine(totalJarsPBNeeded + " jars of peanut butter");
    Console.WriteLine(totalJarsJellyNeeded + " jars of jelly");
    Console.WriteLine("Would you like to start program over? type 'yes' or 'y'");
    string response = Console.ReadLine();

    if (response == "yes") {
        restart = true;
    } else if (response == "y") {
        restart = true;
    } else {
        Console.WriteLine("");
        Console.WriteLine("Goodbye!");
        restart = false;
    }
}


