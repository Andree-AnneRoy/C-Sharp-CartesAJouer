using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartesAJouer
{
    class Program
    {
        enum cartesajouer
        {
            asdepique, deuxdepique, troisdepique, quatredepique, cinqdepique, sixdepique, septdepique, huitdepique, neufdepique, dixdepique, valetdepique, damedepique, roidepique,
            asdecoeur, deuxdecoeur, troisdecoeur, quatredecoeur, cinqdecoeur, sixdecoeur, septdecoeur, huitdecoeur, neufdecoeur, dixdecoeur, valetdecoeur, damedecoeur, roidecoeur,
            asdetrefle, deuxdetrefle, troisdetrefle, quatredetrefle, cinqdetrefle, sixdetrefle, septdetrefle, huitdetrefle, neufdetrefle, dixdetrefle, valetdetrefle, damedetrefle, roidetrefle,
            asdecarreau, deuxdecarreau, troisdecarreau, quatredecarreau, cinqdecarreau, sixdecarreau, septdecarreau, huitdecarreau, neufdecarreau, dixdecarreau, valetdecarreau, damedecarreau, roidecarreau
        };

        static void Main(string[] args)
        {
            int[] Calcul = new int[3];
            string[] tab = new string[3];
            tab[0] = "Tony Stark";
            tab[1] = "Bruce Wayne";
            tab[2] = "Peter Parker";
            tab[3] = "Thor";
            cartesajouer[] Carte = new cartesajouer[5];
            int[] Erreur = new int[tab.Length * Carte.Length];
            Random rnd = new Random();


            for (int index = 0; index <= tab.GetUpperBound(0); index++)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("---------------------" + tab[index] + "---------------------");
                Console.WriteLine();
                for (int compteur = 0; compteur <= Carte.GetUpperBound(0); compteur++)
                {
                    prop:
                    int RandomValeur = rnd.Next(1, 52);
                    foreach (int erreur in Erreur)
                    {
                        if (RandomValeur == erreur)
                        {
                            goto prop;
                        }
                    }
                    Erreur[compteur * index] = RandomValeur;
                    Carte[compteur] = (cartesajouer)RandomValeur;
                    Console.WriteLine(Carte[compteur] + "   " + RandomValeur);
                    Calcul[index] = Calcul[index] + RandomValeur;
                }

                Console.WriteLine();
                Console.WriteLine(Calcul[index]);

                Console.ReadLine();

            }
        }
    }
}
