// A la linia 7 demana els dolars a convertir, a la linia 11 fa la conversio a euros i a la linia 15 mostra per pantalla el resultat de la conversio.
//Declaracio variables
double dolars, resultatEuros, euros;

//Entrada dades
Console.Write("Quants dòlars vols convertir? ");
dolars = Convert.ToDouble(Console.ReadLine());
Console.Write("Quants Euros són un dòlar? ");
euros = Convert.ToDouble(Console.ReadLine());

//Algorisme
resultatEuros = dolars * euros;

//Sortida dades
Console.Clear();
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine($"{dolars}$ a euros són {resultatEuros}€");
