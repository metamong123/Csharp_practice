using static System.Console;

class Animal
{
    public void Cry1() { WriteLine("Animal Cry1"); }

    public void Cry2() { WriteLine("Animal Cry2"); }
}

class Dog : Animal
{
    public void Cry1() { WriteLine("Dog Cry1"); }
    public void Cry2() { WriteLine("Dog Cry2"); }
}

class Program
{
    public static void Main()
    {
        Animal ad = new Dog();

        ad.Cry1();  // ?
        ad.Cry2();  // ?
    }
}

