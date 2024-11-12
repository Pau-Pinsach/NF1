internal class Programa
{//<summary>
//Programa que et demana el radi d'una esfera en metres i et calcula el seu volum (4/3*PI*r*r*r)
//Compte que el programa té una errada. La saps trobar?
//</summary>
//<param name="args"></param>
    private static void Main(string[] args)
    {
//Entrada dades
        const double PI = 3.1415;
        double radi, volum;
        Console.Write("RADI DE L'ESFERA EN METRES? ");
        radi=Convert.ToDouble(Console.ReadLine());
//Algorisme
        volum = 4.0/3.0 * PI * Math.Pow(radi, 3);
//Sortida dades
        Console.WriteLine($"ESFERA DE RADI {radi} TÉ UN VOLUM DE {volum} m3");
    }
}