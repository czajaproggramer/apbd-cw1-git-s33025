namespace Tut2;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Wpisz swoje imie");
        string napis = Console.ReadLine();
        Console.WriteLine("Wpisz swoj wiek");
        int wiek = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Wpisz swoja srednia ocen");
        float srOcen = float.Parse(Console.ReadLine());
        Student student = new Student(wiek, napis, srOcen);
        student.printStud();
    }
}
