using System.Drawing;

namespace Ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracio variables
            string linia;
            int numero, contNegatiu = 0, contPositiu = 0;

            //Entrada dades
            StreamReader fitxer = new StreamReader("NUMEROS.TXT");
            linia = fitxer.ReadLine();

            //Algorisme
            while (linia != null)
            {
                numero = Convert.ToInt32(linia);
                if (numero < 0)
                    contNegatiu++;
                else contPositiu++;
                linia = fitxer.ReadLine();

            }
            fitxer.Close();

            //Sortida dades
            Console.WriteLine($"El fitxer té {contPositiu} positius i {contNegatiu} negatius.");
        }
    }
}
