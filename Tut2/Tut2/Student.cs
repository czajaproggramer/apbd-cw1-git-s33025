namespace Tut2;

public class Student
{
    private int wiek { get; set; }
    private string imie { get; set; }
    private List<int> oceny { get; set; }
    private float sredniaOcen { get; set; }

    public Student(int wiek, string imie, List<int> oceny)
    {
        this.wiek = wiek;
        this.imie = imie;
        float srednia = 0;
        foreach (int ocena in oceny)
        {
            srednia += ocena;
        }

        srednia /= 5;
        sredniaOcen = srednia;
    }
    
    public void printStud()
    {
        Console.WriteLine("Moje imie to: " +
                          imie + ", mam " + wiek + " lat"
                          + ", a moja srednia ocen to " + sredniaOcen);
    }
    
}