namespace Ex13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracio variables
            StreamReader fitxer = new StreamReader("bonus.txt");
            int contTotal = 0, contBonus = 0, valorBonus, percentatge;
            string linia;
            Random aleatori = new Random();

            //Entrada dades
            linia = fitxer.ReadLine();

            //Algorisme
            while(linia != null)
            {
                contTotal++;
                if (linia == "BONUS")
                {
                    contBonus++;
                    valorBonus = aleatori.Next(1, 11);
                }
                linia = fitxer.ReadLine();
            }
            percentatge = contBonus * 100 / contTotal;

            //Sortida dades
            fitxer.Close();
            Console.WriteLine($"S'han distribuit {contBonus} bonus, hi ha un total de {contTotal} billets\ni el percentatge de billets guanyadors és {percentatge}%"); 

        }
    }
}
