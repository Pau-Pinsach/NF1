namespace Ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracio variables
            double dolars, euros;
            const double eurosEnDolars = 0.91;
            //Entrada dades
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Quants dólars vols convertir a Euros? ");
            dolars = Convert.ToDouble(Console.ReadLine());
            //Algorisme
            euros = Conversio(dolars, eurosEnDolars);
            //Sortida dades
            Console.Clear();
            Console.WriteLine($"{dolars}$ són {euros:F2}€");
        }
        static double Conversio(double dolars, double eurosEnDolars)
        {
            double euros;
            euros = dolars / eurosEnDolars;
            return euros;
        }
    }
}
