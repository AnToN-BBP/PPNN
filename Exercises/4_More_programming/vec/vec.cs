using System;

public class vec {
    public double x, y, z;

    // Default constructor
    public vec() {
        x = 0; 
        y = 0; 
        z = 0;
    }

    // Parameterized constructor
    public vec(double x, double y, double z) {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    // Override ToString for easy printing
    public override string ToString() => $"{x} {y} {z}";

    // Optional print method for debugging
    public void print(string label = "") {
        Console.WriteLine($"{label}{x} {y} {z}");
    }

    // -- Mathematical operators --

    // Scalar multiplication
    public static vec operator*(vec v, double c) => new vec(v.x * c, v.y * c, v.z * c);
    public static vec operator*(double c, vec v) => v * c; // commutative

    // Division by a scalar
    public static vec operator/(vec v, double c) => new vec(v.x / c, v.y / c, v.z / c);

    // Vector addition
    public static vec operator+(vec u, vec v) => new vec(u.x + v.x, u.y + v.y, u.z + v.z);

    // Vector negation
    public static vec operator-(vec u) => new vec(-u.x, -u.y, -u.z);

    // Vector subtraction
    public static vec operator-(vec u, vec v) => new vec(u.x - v.x, u.y - v.y, u.z - v.z);

    // -- Dot and Cross Products --

    // Dot product (instance method)
    public double dot(vec other) => x * other.x + y * other.y + z * other.z;
    // Dot product (static method)
    public static double dot(vec u, vec v) => u.x * v.x + u.y * v.y + u.z * v.z;

    // Cross product (static)
    public static vec cross(vec u, vec v) {
        double cx = u.y * v.z - u.z * v.y;
        double cy = u.z * v.x - u.x * v.z;
        double cz = u.x * v.y - u.y * v.x;
        return new vec(cx, cy, cz);
    }

    // -- Norm (magnitude) --
    public double norm() => Math.Sqrt(x*x + y*y + z*z);

    // -- Approximate comparison --
    private static bool approx(double a, double b, double acc=1e-9, double eps=1e-9) {
        if(Math.Abs(a - b) < acc) return true;
        if(Math.Abs(a - b) < (Math.Abs(a) + Math.Abs(b)) * eps) return true;
        return false;
    }

    public bool approx(vec other, double acc=1e-9, double eps=1e-9) {
        return approx(x, other.x, acc, eps)
            && approx(y, other.y, acc, eps)
            && approx(z, other.z, acc, eps);
    }

    public static bool approx(vec u, vec v, double acc=1e-9, double eps=1e-9)
        => u.approx(v, acc, eps);
}
