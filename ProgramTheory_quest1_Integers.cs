using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
    int x = int.MaxValue;
    long y = long.MaxValue;
    short z = short.MaxValue;

    ulong sum = (ulong)(x+y+z);
    Console.WriteLine(sum);
  }
 }
