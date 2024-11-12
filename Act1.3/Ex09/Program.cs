namespace Ex09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracio variables
            double radi, volum, area, perimetre;
            //Entrada dades
            Console.Write("El radi d'una esfera: ");
            radi = Convert.ToDouble(Console.ReadLine());
            //Algorisme
            volum = Volum(radi);
            area = Area(radi);
            perimetre = Perimetre(radi);
            //Sortida dades
            Console.Clear();
            Console.WriteLine($"El radi de l'esfera és {radi}");
            Console.WriteLine($"El volum de l'esfera és {volum}");
            Console.WriteLine($"L'àrea de l'esfera és {area}");
            Console.WriteLine($"El perimetre de l'esfera és {perimetre}");
        }
        static double Volum(double radi)
        {
            double volum;
            volum = 4.0/3 * Math.PI * Math.Pow(radi, 3);
            return Math.Round(volum, 2);
        }
        static double Area(double radi)
        {
            double area;
            area = 4 * Math.PI * Math.Pow(radi, 2);
            return Math.Round(area, 2);
        }
        static double Perimetre(double radi)
        {
            double perimetre;
            perimetre = 2 * Math.PI * radi;
            return Math.Round(perimetre, 2);
        }
    }
}
