using System;

namespace ModeloObjet_quest2_Encapsulation
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            BeerEncapsulator beerEncapsulator = new BeerEncapsulator();
            //Affiche le status des matières
            beerEncapsulator.DisplayStatus();

            Console.WriteLine("Combien de bières à produire (et à boire..)??");
            int bottleToProduce = Convert.ToInt32(Console.ReadLine());
            int bottleProduced ;
            bottleProduced = beerEncapsulator.ProduceEncapsulatedBottles(bottleToProduce);

            //bool test = beerEncapsulator.check_status();
            //Console.WriteLine("CheckStatus vaut" + test);
            Console.WriteLine("J'ai pu produire : " + bottleProduced + " bouteilles");
        }
    }

    class BeerEncapsulator
    {
        private int _availableBeerVolume = 100;//nombre décimal qui représente 
                                                 //en centilitres le volume de bière disponible dans la machine
        private int _availableBottles = 10;
        private int _availableCapsules = 10;
        private int[] statusMaterial ;

        public void AddBeer(int beer_cl)
        {
            _availableBeerVolume += beer_cl;

        }

        public void DisplayStatus()
        {   
            update_status();
          foreach(int valeur in statusMaterial)
          //for (int i =0; i<statusMaterial.Length;i++)
            {
                Console.WriteLine("valeur = " + valeur);
            }
        }

        public int ProduceEncapsulatedBottles(int bottleToProduce)
        {
            int bottlesProduced = 0;
            while (check_status() && bottlesProduced < bottleToProduce)
            {
                _availableBeerVolume -= 33;
                _availableCapsules -= 1;
                _availableBottles -= 1;
                bottlesProduced += 1;
            }

            return bottlesProduced;
        }

        public bool check_status()//méthode pour checker si on peut 
                                   //fabriquer 1 bière
        {
            update_status();
            bool status = true;
            foreach (int valeur in statusMaterial)
            //for (int i =0; i<statusMaterial.Length;i++)
            {
                if (valeur<1)
                    {
                        status = false;
                        break;
                    }
            }
            return status;
        }

        private void update_status()
        {
            statusMaterial = new int[]{ Math.Abs(_availableBeerVolume / 33), _availableBottles, _availableCapsules };
        }

    }
        
}

