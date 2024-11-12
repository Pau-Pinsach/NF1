namespace Ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracio variables
            string linia;
            int contAlex = 0, contIker = 0;
            StreamReader fitxer = new StreamReader("alumnesDAMDAW.txt");

            //Entrada dades
            linia = fitxer.ReadLine();

            //Algorisme
            while (linia != null)
            {
                if (linia == "Alex")
                    contAlex++;
                else if (linia == "Iker")
                    contIker++;
                linia = fitxer.ReadLine();
            }
            fitxer.Close();
            //Sortida dades
            if (contAlex == contIker)
                Console.WriteLine("Hi ha els mateixos Ikers que Alex");
            else if (contAlex > contIker)
                Console.WriteLine("Hi ha més Alex que Ikers");
            else
                Console.WriteLine("Hi ha més Ikers que Alex");
        }
    }
}
