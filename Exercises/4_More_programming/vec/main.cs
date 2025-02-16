using System;

class main {
    static void Main() {
        // Create some test vectors
        vec u = new vec(1, 2, 3);
        vec v = new vec(4, 5, 6);

        Console.WriteLine($"u = {u}");
        Console.WriteLine($"v = {v}");

        // Add vectors
        vec sum = u + v;
        Console.WriteLine($"u + v = {sum}");

        // Subtract vectors
        vec diff = v - u;
        Console.WriteLine($"v - u = {diff}");

        // Scalar multiply
        vec scaled = 2 * u;
        Console.WriteLine($"2 * u = {scaled}");

        // Dot product
        double dotVal = vec.dot(u, v);
        Console.WriteLine($"u · v = {dotVal}");

        // Cross product
        vec crossVal = vec.cross(u, v);
        Console.WriteLine($"u x v = {crossVal}");

        // Norm (magnitude)
        double normU = u.norm();
        Console.WriteLine($"||u|| = {normU}");

        // Approx comparison
        vec uCopy = new vec(1, 2, 3);
        bool same = vec.approx(u, uCopy);
        Console.WriteLine($"u approx uCopy? {same}");
    }
}
