namespace Ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracio variables
            double polzades, metres;
            //Entrada dades
            Console.Write("Quantes polzades vols convertir a metres? ");
            polzades = Convert.ToDouble(Console.ReadLine());
            //Algorisme
            metres = Conversio(polzades);
            //Sortida dades
            Console.Clear();
            Console.WriteLine($"{polzades} polzades convertit a metres són {metres} metres");
        }
        static double Conversio(double polzades)
        {
            double resultatMetres;
            const double cm = 2.54;
            resultatMetres = (polzades * cm) / 100;
            return resultatMetres;

        }
    }
}
