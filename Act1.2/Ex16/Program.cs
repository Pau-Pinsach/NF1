//A la linia 10 es defineix la classe Random, a les linies 13 i 14 es dona un valor aleatori a les variables 
//golsPSG i golsGirona, a la linia 17 es mostra el resultat per pantalla.

//Declaració variables
int minimGols = 0;
int maximGols = 7;
int golsPSG, golsGirona;

//Entrada dades
Random random = new Random();

//Algorisme
golsPSG = random.Next(minimGols, maximGols);
golsGirona = random.Next(minimGols, maximGols);

//Sortida dades
Console.WriteLine($"PSG {golsPSG} - Girona {golsGirona}");