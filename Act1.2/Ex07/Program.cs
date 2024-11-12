// Primer demana el divident i el divisor, a les linies 7 i 9, despres realitza la divisio i el modul d'aquest numeros a les linies 13 i 14, i mostra el resultat per pantalla a les linies 18 i 19.

//Declaracio variables
int divident, divisor, resultatDivisio, resultatModul;

//Entrada dades
Console.Write("Escriu un divident: ");
divident = Convert.ToInt32(Console.ReadLine());
Console.Write("Escriu un divisor: ");
divisor = Convert.ToInt32(Console.ReadLine());

//Algorisme
resultatDivisio = divident / divisor;
resultatModul = divident % divisor;

//Sortida dades
Console.Clear();
Console.WriteLine($"El resultat de la divisió és {resultatDivisio}");
Console.WriteLine($"El resultat del mòdul és {resultatModul}");
