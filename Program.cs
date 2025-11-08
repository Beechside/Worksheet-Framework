internal class Program
{
    static void Main(string[] args)
    {
        Worksheet worksheet = new();
        worksheet.Exercise1();
        worksheet.Exercise2();
        worksheet.Exercise3();
        worksheet.Exercise4();
    }
}

internal class Worksheet
{
    float pi;

    public Worksheet()
    {
        pi = 3.14f;
    }

    public void Exercise1()
    {
        List<int> myList = [1, 2, 3, 4, 5];
        int myInt = 42;
        Exercise1b(myList, myInt);
        Console.WriteLine(string.Join(", ", myList));
        Console.WriteLine(myInt);
    }

    void Exercise1b(List<int> newList, int newInt)
    {
        newList.Add(99);
        newInt = 100;
    }

    public void Exercise2()
    {
        double pi = 3.14159;
        Console.WriteLine(pi);
        Console.WriteLine(this.pi);
    }

    public void Exercise3()
    {
        IAnimal dog = new Dog();
        dog.Speak();

        IAnimal cat = new Cat();
        cat.Speak();
    }

    public void Exercise4()
    {
        Polymorphic obj1 = new Polymorphic("Hello, World!");
        Polymorphic obj2 = new Polymorphic(12345);
    }


}

class Dog : IAnimal
{
    public void Speak()
    {
        Console.WriteLine("Woof!");
    }
}

class Cat : IAnimal
{
    public void Speak()
    {
        Console.WriteLine("Meow!");
    }
}

interface IAnimal
{
    void Speak();
}

internal class Polymorphic
{ 
    public Polymorphic(string myString)
    {
        Console.WriteLine(myString);
    }

    public Polymorphic(int myInt)
    {
        Console.WriteLine(myInt);
    }
}
