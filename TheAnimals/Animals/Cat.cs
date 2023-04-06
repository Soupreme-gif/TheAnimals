namespace Animals.Animals;

public class Cat : Pet, ITalkable
{
    private int mousesKilled;

    public Cat(int mousesKilled, String name) : base(name) {
        this.mousesKilled = mousesKilled;
    }

    public int GetMousesKilled() {
        return mousesKilled;
    }

    public void AddMouse() {
        mousesKilled++;
    }

    
    public String Talk() {
        return "Meow";
    }

    
    public String toString() {
        return "Cat: " + "name=" + name + " mousesKilled=" + mousesKilled;
    }
}