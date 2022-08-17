using System;

class Aula1 {
  public static double f(double x,
                        double a,
                        double b,
                        double c) {
    return a*Math.Pow(x,2) + b*x + c;
  }
  public static double[] zero(double a,
                        double b,
                        double c) {
    double[] r = new double[2];
    if(a != 0) {
      double delta = Math.Pow(b,2) - (4*a*c);
      if (delta >= 0) {
        r[0] = (-b+Math.Sqrt(delta)) / (2*a);
        r[1] = (-b-Math.Sqrt(delta)) / (2*a);
      }
    } else {
      r[0] = -c/b;
    }
    return r;
  }
  public static void Main (string[] args) {
    int v = 0;
    Console.WriteLine(v);
    
    double z = f(1,2,3,4);
    Console.WriteLine(z);
    
    double[] s = zero(1,2,3);
    Console.WriteLine(s[0] + " " + s[1]);
    
    double[] t = zero(1,4,2);
    Console.WriteLine(t[0] + " " + t[1]);

    int[,] m = new int[2,3]{
      {1,2,3},
      {4,5,6}
    };
    Console.WriteLine(m[0,1]);

    foreach(int i in m) {
      Console.WriteLine(i);
    }
    
  }
}