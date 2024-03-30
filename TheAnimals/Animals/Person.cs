namespace Animals.Animals;

public abstract class Person {
    private string name { get; set; }

    public Person(string name) {
        this.name = name;
    }

    public string GetName() {
        return name;
    }

    public void SetName(string name) {
        this.name = name;
    }
}