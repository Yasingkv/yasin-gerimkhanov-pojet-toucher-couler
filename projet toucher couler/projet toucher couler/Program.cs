using System;

namespace projet_toucher_couler
{
    class Program
    {
        static void Main(string[] args)
        {

            int ligne = 10;
            int collone = 10;

            string[,] matrix = new string[ligne, collone];

            Random alea = new Random();
            for (int i = 0; i < ligne; i++)
            {
                for (int j = 0; j < collone; j++)
                {
                    matrix[i, j] = alea.Next(2) == 0 ? "O" : "X"; //(condition) ? (valeur si vrai) : (valeur si faux)
                }
            }
            for (int i = 0; i < ligne; i++)
            {
                for (int j = 0; j < collone; j++)
                {
                    Console.Write("+---");
                }
                Console.Write("+\n");

                for (int j = 0; j < collone; j++)
                {
                    Console.Write("| " + matrix[i, j] + " ");
                }
                Console.Write("|\n");
            }

            for (int j = 0; j < collone; j++)
            {
                Console.Write("+---");
            }
            Console.Write("+\n");

            grille_vide(ligne, collone);

        }
        static void grille_vide(int ligne , int collone)
        {
            for (int i = 0; i < ligne; i++)
            {
                for (int j = 0; j < collone; j++)
                {
                    Console.Write("+---");
                }
                Console.Write("+\n");

                for (int j = 0; j < collone; j++)
                {
                    Console.Write("|   ");
                }
                Console.Write("|\n");
            }

            for (int j = 0; j < collone; j++)
            {
                Console.Write("+---");
            }
            Console.Write("+\n");

        }

    }
}
