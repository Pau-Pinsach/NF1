namespace Ex15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracio variables
            string linia;
            int golsGirona, golsRival,contVisitant = 0, puntsTotal = 0, contVictoria = 0, contEmpat = 0, contDerrota = 0;
            StreamReader fitxer = new StreamReader("Girona_lliga23_24.txt");

            //Entrada dades
            linia = fitxer.ReadLine();
            golsRival = Convert.ToInt32(linia);
            linia = fitxer.ReadLine();
            golsGirona = Convert.ToInt32(linia);

            //Algorisme
            while(linia != null)
            {
                if (contVisitant % 2 == 0)
                {
                    if (golsGirona == golsRival)
                    {
                        contEmpat++;
                        puntsTotal++;
                    }
                    else if (golsGirona > golsRival)
                    {
                        contVictoria++;
                        puntsTotal += 3;
                    }
                    else
                        contDerrota++;
                    linia = fitxer.ReadLine();
                    golsGirona = Convert.ToInt32(linia);
                    linia = fitxer.ReadLine();
                    golsRival = Convert.ToInt32(linia);
                }
                if (contVisitant % 2 == 1)
                {
                    if (golsGirona == golsRival)
                    {
                        contEmpat++;
                        puntsTotal++;
                    }
                    else if (golsGirona > golsRival)
                    {
                        contVictoria++;
                        puntsTotal += 3;
                    }
                    else
                        contDerrota++;
                    linia = fitxer.ReadLine();
                    golsGirona = Convert.ToInt32(linia);
                    linia = fitxer.ReadLine();
                    golsRival = Convert.ToInt32(linia);
                }
                contVisitant++;

            }
            //Sortida dades
            fitxer.Close();
            Console.WriteLine($"El Girona ha guanyat {contVictoria} partits, ha empatat {contEmpat} partits i ha perdut {contDerrota}.\nEls punts totals del Girona són {puntsTotal} punts.");
        }
    }
}
