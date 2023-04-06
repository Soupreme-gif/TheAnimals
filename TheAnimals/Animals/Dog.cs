namespace Animals.Animals;

public class Dog : Pet, ITalkable
{
    private bool friendly;

    public Dog(bool friendly, String name) : base(name) {
        
        this.friendly = friendly;
    }

    public bool IsFriendly() {
        return friendly;
    }
    
    public String Talk() {
        return "Bark";
    }
    
    public String toString() {
        return "Dog: " + "name=" + name + " friendly=" + friendly;
    }
}