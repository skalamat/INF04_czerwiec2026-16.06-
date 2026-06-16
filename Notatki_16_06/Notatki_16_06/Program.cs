Console.WriteLine("Podaj Tytuł notatki");
string tytulUzytkownika = Console.ReadLine();

Notatka n1 = new Notatka("szkoła", "Nauczyć się na egzamin", true);
Notatka n2 = new Notatka(tytulUzytkownika);

n1.WypiszNotatke();
n2.WypiszNotatke();

public class Notatka
{
    public string tytul;
    public string tresc;
    public bool priorytet;
    public DateTime data;

    public Notatka(string _tytul, string _tresc, bool _priorytet)
    {
        tytul = _tytul;
        tresc = _tresc;
        priorytet = _priorytet;
        data = DateTime.Today;
    }

    public Notatka(string _tytul) : this(_tytul, "", false)
    {
        //tytul = _tytul;
        //tresc = "";
        //priorytet = false;
        //data = DateTime.Today;
    }

    //nazwa:    WypiszNotatke
    //parametry:    brak
    //opis:     metoda wypisuje treść notatki,jej tytuł oraz date utworzenia, jeśli notatka ma ustawiony priorytet wyswietli również napis WAŻNA
    //zwracany typ i opis:  brak
    //Autor: 
    public void WypiszNotatke()
    {
        if (priorytet)
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine($"Notatka WAŻNA {tytul}");
            Console.WriteLine($"{tresc}");
            Console.WriteLine($"Data: {data.ToShortDateString()}");
            Console.WriteLine("--------------------------");
        }
        else
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine($"Notatka {tytul}");
            Console.WriteLine($"{tresc}");
            Console.WriteLine($"Data: {data.ToShortDateString()}");
            Console.WriteLine("--------------------------");
        }
    }
}