namespace Tut2;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Wpisz swoje imie");
        string napis = Console.ReadLine();
        Console.WriteLine("Wpisz swoj wiek");
        int wiek = Int32.Parse(Console.ReadLine());
        List<int> oceny = new List<int>();
        oceny.Add(5);
        oceny.Add(2);
        oceny.Add(2);
        oceny.Add(4);
        oceny.Add(3);
        Student student = new Student(wiek, napis, oceny);
        student.printStud();
    }
}
