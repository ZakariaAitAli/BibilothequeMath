using System;
using BibilothequeMath;

class Program
{
    static void Main()
    {
        Addition addition = new Addition();

        int resultatAddition = addition.Add(5, 3);
        Console.WriteLine($"Résultat de l'addition: {resultatAddition}");

        Multiplication multiplication = new Multiplication();

        int resultatMultiplication = multiplication.Multiply(4, 6);
        Console.WriteLine($"Résultat de la multiplication: {resultatMultiplication}");

        Console.ReadLine();
    }
}