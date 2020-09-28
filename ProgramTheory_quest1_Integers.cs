using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
    int x = int.MaxValue;
    long y = long.MaxValue;
    short z = short.MaxValue;

    ulong sum = (ulong)x + (ulong)y + (ulong)z;
    Console.WriteLine(sum);
  }
 }
