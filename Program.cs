using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj liczbę całkowitą:");
        int input = int.Parse(Console.ReadLine());

        int result = SzukanieKolejnej(input);
        Console.WriteLine("Następna liczba spełniająca warunki: " + result);
    }
// def funkcja SzukanieKolejnej
    static int SzukanieKolejnej(int n)
    {
        while (true)
        {
            n++; // zwiekszamy o 1
            if (n % 2 == 1 && n % 3 == 0 && IsUniqueDigits(n))
            {
                return n;
            }
        }
    }
    static bool IsUniqueDigits(int number) //metoda sprawdzenie powtorzen
    {
        // konwersja liczby
        char[] digits = number.ToString().ToCharArray();

        // szukamy powtórzeń
        return digits.Distinct().Count() == digits.Length;
    }
}

