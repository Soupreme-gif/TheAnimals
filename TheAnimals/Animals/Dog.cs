namespace Animals.Animals;

public class Dog : Pet, ITalkable
{
    private bool _friendly;

    public Dog(bool friendly, String name) : base(name) {
        
        this._friendly = friendly;
    }

    public bool IsFriendly() {
        return _friendly;
    }
    
    public String Talk() {
        return "Bark";
    }
    
    public String toString() {
        return "Dog: " + "name=" + name + " friendly=" + _friendly;
    }
}