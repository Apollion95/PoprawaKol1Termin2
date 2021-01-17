using System;

namespace ConsoleApp1
{
    class Program
    {
        public static void Zad1(double odleglosc,string pogoda)
        {
            double wynik;
            double predkosc = 0;
            DateTime czas = new DateTime();
            DateTime czasdodawanie=czas;
            if (pogoda == "Sloneczna")
            {
                predkosc = 30;
                do
                {
                    czas = czasdodawanie.AddHours(+1);
                    czasdodawanie = czas;
                    odleglosc -= 30;
                    Console.WriteLine("Snieg, Dojazd zajal " + czasdodawanie.Hour + " godzin " + czasdodawanie.Minute + " minut oraz pozostaly dystans " + odleglosc);
                } while (odleglosc >= 30);
            }
            if (pogoda == "PadaDeszcz")
            {
                predkosc = 25;
                do
                {
                    czas = czasdodawanie.AddHours(+1);
                    czasdodawanie = czas;
                    odleglosc -= 25;
                    Console.WriteLine("Snieg, Dojazd zajal " + czasdodawanie.Hour + " godzin " + czasdodawanie.Minute + " minut oraz pozostaly dystans " + odleglosc);
                } while (odleglosc >= 25);
            }
            if (pogoda == "Snieg")
            {
                predkosc = 20;
                czas.AddMinutes(+10);
                do
                {
                    czas = czasdodawanie.AddHours(+1);
                    czasdodawanie = czas;
                    odleglosc -= 20;
                    Console.WriteLine("Snieg, Dojazd zajal " + czasdodawanie.Hour + " godzin " + czasdodawanie.Minute + " minut oraz pozostaly dystans "+odleglosc);
                } while (odleglosc >= 20);
               
            }
        }
        //zad1
        //Oblicz czas dojazdu.Napisz funkcję która przyjmie dwa parametry: odległość(zmiennoprzecinkowa) i pogodę(tekst). // ok //enum?
        //Przyjmij że średnia prędkość jazdy to 30km / h jeśli pogoda jest słoneczna. 
        //Jeśli pada deszcz, średnia prędkość spada do 25km / h.Jeśli pada śnieg, średnia prędkość to 20km / h i dolicz dodatkowo 10 min na odśnieżanie samochodu. 
        //Funkcja powinna zwrócić wynik w minutach. Przetestuj funkcję


        public static void Zad2()
        {
            string[,] tablica = new string[2, 5];
            var str = String.Join(",", tablica);
            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    Console.WriteLine("Podaj Imie po spacji nazwisko, po przecinku nowe imie i nazwisko");
                }
      
            }
        }
        //zad2
        //Napisz funkcję, która zwróci dwuwymiarową tablicę typu tekstowego.Wczytaj tekst od użytkownika.Powinny się w nim znaleźć imiona i nazwiska. 
        //Imiona i nazwiska różnych osób powinny być oddzielone od siebie przecinkami, natomiast imiona od nazwisk spacją.
        //Zwracana tablica powinna posiadać 2 kolumny - imię i nazwisko.Ilość wierszy powinna zależeć od tekstu wprowadzonego przez użytkownika.
        //Przetwórz tekst w taki sposób, aby wypełnić tablicę i zwróć ją jako wynik funkcji.Przetestuj funkcję, wypisz na
        //ekran ilość wierszy otrzymanej tablicy.
        static void Main(string[] args)
        {
            Zad1(90, "Sloneczna");
            Zad1(80, "PadaDeszcz");
            Zad1(70, "Snieg");
        }
    }
}
