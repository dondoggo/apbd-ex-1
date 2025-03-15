using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] liczby = { 1, 2, 3, 4, 5 };

        double srednia = ObliczSrednia(liczby);
        Console.WriteLine($"Średnia z tablicy wynosi: {srednia}");

        int maksymalna = ZnajdzMaksymalna(liczby);
        Console.WriteLine($"Maksymalna wartość w tablicy to: {maksymalna}");
    }

    public static double ObliczSrednia(int[] liczby)
    {
        return liczby.Average();
    }

    public static int ZnajdzMaksymalna(int[] liczby)
    {
        return liczby.Max();
    }
}
