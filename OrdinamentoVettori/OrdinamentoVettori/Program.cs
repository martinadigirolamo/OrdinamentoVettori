using System;

namespace OrdinamentoVettori
{
    class Program
    {
        static void Main(string[] args)
        {

            //creazione del vettore
            int [] vettore = new int [10] { 11, 55, -9, 7, 74, 147, -87, 6, 0, 18};

            //richiamo al metodo di ordinamento
            ordina(vettore);

            //ciclo per stampare a video il contenuto del vettore
            for (int i = 0; i < 10; i++)
                Console.WriteLine(vettore[i]);

            Console.ReadKey();
        }


        //metodo per ordinamento array
        static void ordina (int[] vettore)
        {
            Array.Sort(vettore);
        }

     
    }
}
