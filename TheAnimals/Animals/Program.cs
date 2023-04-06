// See https://aka.ms/new-console-template for more information


using Animals.Animals;

FileReader outOfFile  = new FileReader("animals.txt"); 
    FileWriter intoFile = new FileWriter("animals.txt");
    List<ITalkable> zoo = new List<ITalkable>();

        AnimalCreator creator = new AnimalCreator();

        for(int i = 0; i < Int32.MaxValue; i++)
        {
            creator.CreateAnimal(zoo);
            
            Console.WriteLine("Add more animals? type no to exit");
            var response = Console.ReadLine();

            if (response == "no")
            {
                break;
            }

        }

       

        foreach (var animals in zoo)
        {
            Console.WriteLine(animals.GetName() + " says=" + animals.Talk());
        }
    