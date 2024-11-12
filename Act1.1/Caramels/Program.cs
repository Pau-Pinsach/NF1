internal class Programa
{//<summary>
//Un professor ha decidit repartir un total de caramels entre els nens de la seva classe
//El professor vol repartir el màxim de caramels per nen, però vol que tots els nens tinguin el mateix # de caramels
//El professor es quedarà els caramels que sobrin.
//El programa ha de demanar el # de caramels i el # de nens i informar de 
//a)quants caramels toquen per a cada nen
//b)quants caramels es quedarà el professor
//</summary>
//<param name="args"></param>
    private static void Main(string[] args)
    {
        int nCaramels, nNens;
        int caramelsPerNen, sobren;
        Console.Clear();
        Console.Write("QUANTS NENS? ");
        nNens=Convert.ToInt32(Console.ReadLine());
        Console.Write("QUANTS CARAMELS? ");
        nCaramels=Convert.ToInt32(Console.ReadLine());
        caramelsPerNen=nCaramels/nNens;
        sobren = nCaramels % nNens;
        Console.WriteLine($"TOTAL NENS: {nNens}\t\t TOTAL CARAMELS: {nCaramels}");
        Console.WriteLine($"TOQUEN A {caramelsPerNen} CARAMELS PER CADA NEN");
        Console.WriteLine($"EL PROFESSOR ES QUEDA {sobren} CARAMELS");
    }

}