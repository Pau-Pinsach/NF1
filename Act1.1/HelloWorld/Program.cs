internal class Programa
{
    //<summary>
    //Escriu un programa que et demani el teu nom i et saludi dient HOLA + El teu nom
    //</summary>
    //<param name="args"></param>
    private static void Main(string[] args)
    {
        string nom;
        Console.Clear();
        Console.Write("COM ET DIUS? ");
        nom=Console.ReadLine();
        Console.Clear();
        Console.WriteLine($"Hola {nom}");
    }
}