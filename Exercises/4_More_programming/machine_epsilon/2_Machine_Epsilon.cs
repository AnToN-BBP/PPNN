using System;

class Program {
    static void Main() {
        // 2a. Double precision machine epsilon
        double x = 1.0;
        while (1.0 + x != 1.0) {
            x /= 2.0;
        }
        x *= 2.0;
        Console.WriteLine($"Calculated double epsilon = {x}");
        
        // Check with theoretical value 2^(-52)
        Console.WriteLine($"Expected double epsilon ~ {Math.Pow(2, -52)}");

        // 2b. Single precision machine epsilon
        float y = 1F;
        while (1F + y != 1F) {
            y /= 2F;
        }
        y *= 2F;
        Console.WriteLine($"Calculated float epsilon = {y}");

        // Check with theoretical value 2^(-23)
        Console.WriteLine($"Expected float epsilon ~ {Math.Pow(2, -23)}");
    }
}
