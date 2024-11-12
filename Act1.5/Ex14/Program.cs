namespace Ex14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Declaracio variables
            StreamReader fitxer = new StreamReader("BONUS2.txt");
            int contTotal = 0, contBonus = 0, valorBonus, percentatge, valorTotal = 0;
            string linia;
            Random aleatori = new Random();

            //Entrada dades
            linia = fitxer.ReadLine();

            //Algorisme
            while (linia != null)
            {
                contTotal++;
                if (linia == "BONUS")
                {
                    linia = fitxer.ReadLine();
                    valorBonus = Convert.ToInt32(linia);
                    contBonus++;
                    valorTotal += valorBonus;
                }
                linia = fitxer.ReadLine();
            }
            percentatge = contBonus * 100 / contTotal;

            //Sortida dades
            fitxer.Close();
            Console.WriteLine($"S'han distribuit {contBonus} bonus, hi ha un total de {contTotal} billets i el percentatge de billets guanyadors és {percentatge}%, amb un total de diners guanyats de {valorTotal}€");

        }
    }
}
