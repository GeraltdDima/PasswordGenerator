using System;
using System.Collections.Generic;

public class Program
{
    private static readonly Random random = new Random(); // Fix: Specify type 'Random'

    public static void Main(string[] args)
    {
        string selector = "qwertyuiopasdfghjklzxcvbnm,./;'[]";

        int randomCount = random.Next(1, 15);

        string result = string.Concat(GeneratePassword(randomCount, selector));

        Console.WriteLine(result);
    }

    public static IEnumerable<char> GeneratePassword(int count, string selector)
    {
        for (int i = 0; i < count; i++)
        {
            yield return selector[random.Next(selector.Length)];
        }
    }
}

