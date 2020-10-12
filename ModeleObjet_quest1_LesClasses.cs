using System;

class MainClass {
  public static void Main (string[] args) {
    Character Joueur1 = new Character();
    Character Joueur2 = new Character();
    Console.WriteLine ("Nom Joueur 1");
    Joueur1.nom = Console.ReadLine();
    
    Console.WriteLine ("Nom Joueur 2");
    Joueur2.nom = Console.ReadLine();

    Joueur1.Create();
    Joueur2.Create();

    bool jeuContinue = true;
    bool TourDeJouer = true;
    int Tour = 0;
    while (jeuContinue)
    {
      TourDeJouer = !TourDeJouer;
      //Joueur 1 attaque Joueur2
      if (TourDeJouer)
      {
      Console.WriteLine($"{Joueur1.nom} attaque {Joueur2.nom}");
      Joueur1.Attack(Joueur2);
      
          if (Joueur2.isAlive())
          {
              Console.WriteLine($"{Joueur2.nom} toujours en vie");
              Tour++;
              Console.WriteLine($"Tour : {Tour}");
              Console.WriteLine($"Vie Joueur 2 : {Joueur2.pointsDeVie}");
          }
          else
          {
              Console.WriteLine($"{Joueur2.nom} est mort!...en {Tour} tours");
              jeuContinue=false;
              
          }
      }

      //Joueur 2 attaque Joueur1
      if (!TourDeJouer)
      {
        Console.WriteLine($"{Joueur2.nom} attaque {Joueur1.nom}");
        Joueur2.Attack(Joueur1);
        
        if (Joueur1.isAlive())
        {
            Console.WriteLine($"{Joueur1.nom} toujours en vie");
            Tour++;
            Console.WriteLine($"Tour : {Tour}");
            Console.WriteLine($"Vie Joueur1 : {Joueur1.pointsDeVie}");
        }
        else
        {
            Console.WriteLine($"{Joueur1.nom} est mort!...en {Tour} tours");
            jeuContinue=false;
            
        }
      }
    }
  }

  public class Character
  {
    public string nom;
    public int pointsDeVie;
    public int ForceAttaque;
    public int ForceDefense;

    public bool isAlive()
    {
        if (pointsDeVie >0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public void Attack(Character Opponent)
    {
        Opponent.pointsDeVie = Opponent.pointsDeVie - (ForceAttaque - Opponent.ForceDefense);
    }
      public void Create()
    {
        Random random = new Random();
      
              
        pointsDeVie = random.Next(1,1000);
        ForceAttaque = random.Next(51,100);
        ForceDefense = random.Next(1,50);
    
    }

  }
}
