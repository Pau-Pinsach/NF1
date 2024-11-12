//A la linia 7 ens demana l'alçada en peus, a les linies 11 i 12 calcula l'equivalent en polzades i en metres
//A la linia 17 ens mostra els resultats per pantalla.
//Declaracio variables
double peus, polzades, metres;
const double cm = 2.54;

//Entrada dades
Console.Write("Alçada en peus: ");
peus = Convert.ToDouble(Console.ReadLine());

//Algorisme
polzades = peus * 12;
metres = (polzades * cm) / 100;

//Sortida dades
Console.Clear();
Console.WriteLine($"{peus} peus són {polzades} polzades i {metres} metres.");