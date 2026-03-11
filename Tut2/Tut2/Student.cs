namespace Tut2;

public class Student
{
    private int wiek { get; set; }
    private string imie { get; set; }
    private float sredniaOcen { get; set; }

    public Student(int wiek, string imie, float sredniaOcen)
    {
        this.wiek = wiek;
        this.imie = imie;
        this.sredniaOcen = sredniaOcen;
    }
    
    public void printStud()
    {
        Console.WriteLine("Moje imie to: " +
                          imie + ", mam " + wiek + " lat"
                          + ", a moja srednia ocen to " + sredniaOcen);
    }
    
}