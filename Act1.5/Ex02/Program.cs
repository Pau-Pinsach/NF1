namespace Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracio variables
            string linia;
            int numero, cont = 0;

            //Entrada dades
            StreamReader fitxer = new StreamReader("NUMEROS.TXT");
            linia = fitxer.ReadLine();
            
            //Algorisme
            while (linia != null)
            {
                numero = Convert.ToInt32(linia);
                cont++;
                linia = fitxer.ReadLine();
            }
            fitxer.Close();
            Console.WriteLine($"Hem trobat {cont} valors.");
        }
    }
}
