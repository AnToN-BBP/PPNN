using System;      // for Console
using static System.Math; // so we can write Sqrt(...) directly
class main {
    static void Main() {
        // Part 1: simple math
        double sqrt2 = Sqrt(2.0);
        Console.WriteLine($"sqrt(2) = {sqrt2}");

        double twototheonefifth = Pow(2.0, 1.0/5.0);
        Console.WriteLine($"2^(1/5) = {twototheonefifth}");

        double epi = Pow(E, PI);
        Console.WriteLine($"e^pi = {epi}");

        double pie = Pow(PI, E);
        Console.WriteLine($"pi^e = {pie}");

        // Part 2: gamma function
        // calling sfuns.fgamma(...) from the separate library
        for(int i=1; i<=10; i++){
            double val = sfuns.fgamma(i);
            Console.WriteLine($"Gamma({i}) = {val}");
        }
    }
}
