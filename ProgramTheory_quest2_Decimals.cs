using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
    float x = (float)Math.PI;
    Console.WriteLine($"float Pi = {x}");

    double y = (double)Math.PI;
    Console.WriteLine($"double Pi = {y}");

    decimal z = (decimal)Math.PI;
    Console.WriteLine($"decimal Pi = {z}");
  }
}
