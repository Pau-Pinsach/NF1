namespace Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaració variables
            double x1, y1, x2, y2, distancia;
            //Entrada dades
            Console.Write("Donem el valor x del primer punt: ");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Donem el valor y del primer punt: ");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Donem el valor x del segon punt: ");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Donem el valor y del segon punt: ");
            y2 = Convert.ToInt32(Console.ReadLine());
            //Algorisme
            distancia = Distancia((int)x1, (int)x2, (int)y1, (int)y2);
            //Sortida dades
            Console.Clear();
            Console.WriteLine($"La distancia entre els dos punts és {distancia}.");
        }
        static double Distancia(int x1, int x2, int y1, int y2)
        {
            double distanciaTotal;
            distanciaTotal = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1,2));
            return distanciaTotal;
        }
    }
}
