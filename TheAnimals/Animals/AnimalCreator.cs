namespace Animals.Animals;

public class AnimalCreator

{

    public void CreateAnimal(List<ITalkable> theZoo)
    {
        var animalToCreate = "";
        var animalName = "";
        var response = "";
        
        var isValidGuess = false;

        do
        {
            Console.WriteLine("What type of Animal would you like to create?");
            Console.WriteLine("Your options are");
            Console.WriteLine("1. Dog");
            Console.WriteLine("2. Cat");
            Console.WriteLine("3. Teacher");
            animalToCreate = Console.ReadLine();

            if (animalToCreate.ToLower() != "dog" && animalToCreate.ToLower() != "cat" && animalToCreate.ToLower() != "teacher")
            {
                Console.WriteLine("invalid input please try again");
                isValidGuess = false;
            }
            else
            {
                isValidGuess = true;
            }

        } while (isValidGuess == false);
        
        Console.WriteLine("What is the name of the Animal");
        animalName = Console.ReadLine();

        if (animalToCreate.ToLower() == "dog")
        {

            var isFriendly = false;

            do
            {
                Console.WriteLine("Are they friendly? yes/no");
                response = Console.ReadLine();

                if (response.ToLower() == "yes")
                {
                    isFriendly = true;
                }
                else if(response.ToLower() == "no")
                {
                    isFriendly = false;
                }
                else
                {
                    Console.WriteLine("invalid response please try again");
                }
                
            }while (response.ToLower() != "yes" && response.ToLower() != "no");

            ITalkable dog = new Dog(isFriendly, animalName);
            
            theZoo.Add(dog);

        }
        
        else if(animalToCreate.ToLower() == "cat")
        {

            bool isANumber;
            int miceCount = 0;

            do
            {
                Console.WriteLine("How many mice has the cat killed?");
                response = Console.ReadLine();

                isANumber = TestForNumber(response);

                if (isANumber == false)
                {
                    Console.WriteLine("invalid input please try again");
                }


            } while (isANumber == false);

            miceCount = int.Parse(response);
            
            ITalkable cat = new Cat(miceCount, animalName);
            
            theZoo.Add(cat);
            
        }

        else if(animalToCreate.ToLower() == "teacher")
        {
            bool isANumber;
            int age = 0;

            do
            {
                Console.WriteLine("How old are they?");
                response = Console.ReadLine();

                isANumber = TestForNumber(response);

                if (isANumber == false)
                {
                    Console.WriteLine("invalid input please try again");
                }


            } while (isANumber == false);

            age = int.Parse(response);
            
            ITalkable teacher = new Teacher(age, animalName);
            
            theZoo.Add(teacher);
        }
        
    }
    
    private bool TestForNumber(string response)
    {

        int number = 0;
        bool isNumeric = int.TryParse(response, out number);

        return isNumeric;

    }

}