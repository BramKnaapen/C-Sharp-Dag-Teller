// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Wat is het jaar?: ");
        int jaar = int.Parse(Console.ReadLine());
        Console.WriteLine("Wat is het maandnummer?: ");
        int maand = int.Parse(Console.ReadLine());
        Console.WriteLine("Wat is de dag?: ");
        int dag = int.Parse(Console.ReadLine());

        DateTime ingevuldeDatum = new DateTime(jaar, maand, dag);
        DateTime nuDatum = DateTime.Now;
        TimeSpan verschil = nuDatum - ingevuldeDatum;
        Console.WriteLine(verschil.Days);
    }
}