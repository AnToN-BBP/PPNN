using System;

class Program {
    static void Main() {
        double epsilon = Math.Pow(2, -52); // or from your while-loop approach
        double tiny = epsilon / 2.0;

        double a = 1 + tiny + tiny;
        double b = tiny + tiny + 1;

        Console.WriteLine($"a = {a}");
        Console.WriteLine($"b = {b}");
        Console.WriteLine($"a==b? { (a == b) }");
        Console.WriteLine($"a>1?   { (a > 1.0) }");
        Console.WriteLine($"b>1?   { (b > 1.0) }");
    }
}
