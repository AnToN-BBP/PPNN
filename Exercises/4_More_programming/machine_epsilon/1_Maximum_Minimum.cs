using System;

class Program {
    static void Main() {
        // 1a. Maximum integer
        int maxInt = 1;
        while (maxInt + 1 > maxInt) {
            maxInt++;
        }
        Console.WriteLine($"My max int = {maxInt}");  // should be 2147483647
        
        // 1b. Minimum integer
        int minInt = -1;
        while (minInt - 1 < minInt) {
            minInt--;
        }
        Console.WriteLine($"My min int = {minInt}");  // should be -2147483648
    }
}
