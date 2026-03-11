namespace Tut2;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Wpisz swoje imie");
        string napis = Console.ReadLine();
        Console.WriteLine(napis);
        Student student = new Student(25, "Jarek", 5.0f);
    }
}
