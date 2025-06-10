namespace SuiteDeFebonacciConsoleSansMethodeRecursive;

public class SuiteDeFebonacciConsole
{
    public static void Lancer()
    {
        SuiteDeFebonacci();
    }

    public static void SuiteDeFebonacci()
    {
        for (int i = 0; i < 1; i++)
        {
            int nombreUn = 0;
            int nombreDeux = 1;
            Console.WriteLine(nombreUn);
            Console.WriteLine(nombreDeux);

            for (int a = 0; a < 30; a++)
            {
                int resultat = nombreUn + nombreDeux;
                Console.WriteLine(resultat);

                nombreUn = nombreDeux;
                nombreDeux = resultat;

            }
        }

    }
}
