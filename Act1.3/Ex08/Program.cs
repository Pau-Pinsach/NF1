namespace Ex08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaració variables
            int segons;
            string hora;
            //Entrada dades
            Console.Write("Segons totals: ");
            segons = Convert.ToInt32(Console.ReadLine());
            //Algorisme
            hora = segonsMinutsSegons(segons);
            //Sortida dades
            Console.Clear();
            Console.WriteLine($"{hora}");
        }
        static string segonsMinutsSegons(int segonsTotals)
        {
            int segons, minuts, hores;
            hores = segonsTotals / 3600;
            minuts = (segonsTotals % 3600) / 60;
            segons = segonsTotals % 60;
            return string.Format($"{hores:D2}:{minuts:D2}:{segons:D2}");
        }
    }
}
