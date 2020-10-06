using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
    int[] array = new int[3];
    int[][] jaggedArray = new int[3][];
    array[0] = {1, 2, 3}; 
    array[1] = {2, 3, 4};
    array[1] = {3, 4, 5};

    jaggedArray[0]=[1,2,3] ;
    jaggedArray[1]=[3,4] ;
    jaggedArray[2]=[5] ;

   for (int i=0; i<array.Length;i++)
   {
    //Enlever élément supplémentaire par rapport
    // au tableau irrégulier
    if (array[i].Length != jaggedArray[i].Length)
    {
      int tailleAr_i = array[i].Length;
      int diffTaille= Math.Abs(array[i].Length-jaggedArray[i].Length);
      
      if (diffTaille>0)
      {
        for (int j=0;j<diffTaille;j++)
        {
          ArrayList.Remove(array[i,tailleAr_i-j]);
        }
      }
    }
    //Je place l'élément du tableau régulier dans
    //le tableau irrégulier
    jaggedArray[i]=array[i];
   } 
   //J'affiche mon tableau irrégulier
   for (int i=0; i<jaggedArray.Length;i++)
   {
     Console.WriteLine($"jaggedArray[{i}] = {jaggedArray[i]}");
   }
  }
}
