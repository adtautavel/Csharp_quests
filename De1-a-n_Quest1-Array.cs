using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
    string[] stringArray = new string[2];
    string[] stringArray2 = new string[2];
    string[] stringArray3 = new string[4];
    stringArray[0]="John";
    stringArray[1]="Petros";
    stringArray2[0]="Eddy";
    stringArray2[1]="Raul";
    
    stringArray.CopyTo(stringArray3,0);
    stringArray2.CopyTo(stringArray3,stringArray2.Length);
    
    for (int i =0; i<stringArray3.Length;i++)
      {
     
      Console.WriteLine($"stringArray3[{i}]={stringArray3[i]}");
     }
     
  

  }
}
