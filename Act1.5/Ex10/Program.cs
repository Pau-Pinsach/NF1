namespace Ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracio variables
            int dau, cont = 0, cont1 = 0, cont6 = 0;
            Random aleatori = new Random();

            //Entrada dades
            dau = aleatori.Next(1, 7);

            //Algorisme
            while(cont1 != cont6 || cont1 == 0 || cont6 == 0)
            {
                if (dau == 1)
                    cont1++;
                else if (dau == 6)
                    cont6++;
                cont++;
                dau = aleatori.Next(1, 7);
            }

            //Sortida dades
            Console.WriteLine($"Hem tirat el dau {cont} vegades, i ha sortit el número 6, {cont6} vegades i el número 1, {cont1} vegades.");
        }
    }
}
