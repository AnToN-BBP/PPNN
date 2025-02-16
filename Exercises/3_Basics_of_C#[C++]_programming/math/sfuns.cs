using static System.Math; // This allows you to write Sin(...) instead of Math.Sin(...)

public static class sfuns {
    public static double fgamma(double x) {
        // Reflection formula
        if(x < 0)
            return PI / Sin(PI * x) / fgamma(1 - x);

        // Recurrence up to x >= 9
        if(x < 9)
            return fgamma(x + 1) / x;

        // Stirling approximation
        double lnfgamma = x*Log(x + 1.0/(12.0*x - 1.0/(10.0*x)))
                        - x
                        + 0.5*Log(2.0 * PI / x);
        return Exp(lnfgamma);
    }

    // (Optional) If you want lnGamma, you can add:
    public static double lnGamma(double x) {
        if(x <= 0) return double.NaN;
        if(x < 9)
            return lnGamma(x + 1) - Log(x);

        // same Stirling approach, but keep it in log form
        double val = x * Log(x + 1.0/(12.0*x - 1.0/(10.0*x)))
                     - x
                     + 0.5*Log(2.0 * PI / x);
        return val;
    }
}
