namespace Ex16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracio variables
            string linia;
            double radi, x, y, distancia;
            StreamReader fitxer = new StreamReader("coordenades.txt");

            //Entrada dades
            Console.Write("Introdueix un valor per el radi: ");
            radi = Convert.ToDouble(Console.ReadLine());
            linia = fitxer.ReadLine();
            x = Convert.ToDouble(linia);
            linia = fitxer.ReadLine();
            y = Convert.ToDouble(linia);

            //Algorisme
            while( linia != null )
            {
                distancia = Math.Sqrt(x * x + y * y);
                if (distancia > radi)
                    Console.WriteLine($"El punt ({x},{y}) està fora de la circumferència.");
                else if (distancia ==  radi)
                    Console.WriteLine($"El punt ({x},{y}) està sobre de la circumferència.");
                else
                    Console.WriteLine($"El punt ({x},{y}) està dins de la circumferència.");

                linia = fitxer.ReadLine();
                x = Convert.ToDouble(linia);
                linia = fitxer.ReadLine();
                y = Convert.ToDouble(linia);
            }
        }
    }
}
