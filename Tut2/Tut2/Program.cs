namespace Tut2;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Wpisz swoje imie");
        string nazwa = Console.ReadLine();
        Console.WriteLine("Wpisz swoj wiek");
        int wiek = Int32.Parse(Console.ReadLine());
        List<int> oceny = new List<int>();
        oceny.Add(3);
        oceny.Add(3);
        oceny.Add(3);
        oceny.Add(4);
        oceny.Add(7);
        Student student = new Student(wiek, nazwa, oceny);
        student.printStud();
    }

    static int CalculateMax(int[] values)
    {
        Console.WriteLine("Ta funkcja powinna cos robic, ale nic nie robi;;((");
        return 67;
    }

    static int CalculateMin(int[] values)
    {
        Console.WriteLine("Ta fk. tez nic nie robi hehe");
        return 1;
    }
}
