namespace Animals.Animals;

public class Cat : Pet, ITalkable
{
    private int _mousesKilled;

    public Cat(int mousesKilled, String name) : base(name) {
        this._mousesKilled = mousesKilled;
    }

    public int GetMousesKilled() {
        return _mousesKilled;
    }

    public void AddMouse() {
        _mousesKilled++;
    }

    
    public String Talk() {
        return "Meow";
    }

    
    public String toString() {
        return "Cat: " + "name=" + name + " mousesKilled=" + _mousesKilled;
    }
}