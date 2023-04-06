namespace Animals.Animals;

public class Teacher : Person, ITalkable
{
    private int _age;

    public Teacher(int age, string name) : base(name)
    {
        this._age = age;
    }

    public string Talk()
    {
        return "Don't forget to do the assigned reading!";
    }

    public int GetAge() {
        return _age;
   }

   public void SetAge(int age) {
        _age = age;
   }

    
}


   
