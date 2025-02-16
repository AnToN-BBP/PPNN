using System;
using static System.Math;

class Program {
    public static bool approx(double a, double b, double acc = 1e-9, double eps = 1e-9) {
        if (Abs(a - b) <= acc) 
            return true; 
        if (Abs(a - b) <= Max(Abs(a), Abs(b)) * eps) 
            return true;
        return false;
    }

    static void Main() {
        double d1 = 0.1 + 0.1 + 0.1 + 0.1 + 0.1 + 0.1 + 0.1 + 0.1; // 8 times 0.1
        double d2 = 8 * 0.1;
        
        Console.WriteLine($"d1 = {d1:e15}");
        Console.WriteLine($"d2 = {d2:e15}");
        Console.WriteLine($"d1 == d2? => { (d1 == d2) }");        // Usually false
        Console.WriteLine($"approx(d1,d2)? => { approx(d1, d2) }");  // Should be true
    }
}
