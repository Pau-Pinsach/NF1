// A la linia 7 demana una lletra, converteix la lletra de string a char, a la linia 11 converteix la lletra a el numero de la taula ASCII. I a la linia 15 mostra el resultat per pantalla.
// Declaracio de variables
char lletra;
int ascii;

//Entrada dades
Console.Write("Diguem una lletra: ");
lletra = Convert.ToChar(Console.ReadLine());

//Algorisme
ascii = lletra;

//Sortida dades
Console.Clear();
Console.WriteLine($"La lletra {lletra}, a la taula ASCII és {ascii}");