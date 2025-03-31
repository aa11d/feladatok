using System;


struct Par { public int ossze, csere; }

class Rendezesek
{
    static int[] tomb;
    const int N = 30;

    static void kiir()
    {
        for(int i=0; i<N; i++)
            System.Console.Write(tomb[i]+" ");
        System.Console.WriteLine();
    }

    static void csere(int i, int j) // i-edik és j-edik cseréje
    {
        int plusz = tomb[i];
        tomb[i] = tomb[j];
        tomb[j] = plusz;
    }


    static void Main() 
    {

        tomb = new int[N];
        Random rnd = new ();
        for(int i=0; i<N; i++)
            tomb[i] = rnd.Next(10000,100000); // 10000-99999
        kiir();

        int[] ment = (int[]) tomb.Clone();
     
        // Par bub = buborek();
        // kiir();
        // System.Console.WriteLine(bub.ossze+"--"+bub.csere);

        // tomb = (int[]) ment.Clone();
        // Par min = minKivRend();
        // kiir();
        // System.Console.WriteLine(min.ossze+"--"+min.csere);
       
	}

} // class