namespace Chasse_cerf;

class Program
{
    static void Main(string[] args)
    {
        /*
        Arthur dispose de 5 flèches pour chasser un cerf.

        Consignes :
        - Demander au joueur si chaque tir touche ou rate la cible.
        - Décrémenter le nombre de flèches après chaque tir.
        - Compter le nombre de tirs réussis.
        - Arrêter la chasse lorsque les 5 flèches sont utilisées.
        - Arrêter immédiatement la chasse si le cerf est touché 3 fois.
        - Si la saisie est invalide, demander une nouvelle réponse
          sans consommer de flèche.
        - Afficher le bilan final de la chasse.
        */
        int arrows = 5;
        int hits = 0;
        System.Console.WriteLine("You see a deer in the distance.");
        System.Console.WriteLine("You have 5 arrows at your disposal.");
        while (true)
        {
            System.Console.WriteLine("Do you wish to hit the deer? Y/N");
            string answer = Console.ReadLine();
            if (answer == "Y" || answer == "y")
            {
                System.Console.WriteLine("You have shot an arrow.");
                hits++;
                arrows--;
            }
            else if (answer == "N" || answer == "n")
            {
                System.Console.WriteLine("You deliberately miss the arrow for some reason");
                arrows--;
            }
            else System.Console.WriteLine("Invalid input, please try again:");
            System.Console.WriteLine($"You have {arrows} arrows left");
            if (hits == 3 || arrows == 0)
            {
                System.Console.WriteLine("The hunt is over.");
                System.Console.WriteLine($"You now have {arrows} arrows left, and you hit the deer {hits} times,");
                if(hits == 3)
                {
                    System.Console.Write("thus killing it.");
                }
                else System.Console.Write("it unfortunately ran away though.");
                break;
            }
        }

    }
}