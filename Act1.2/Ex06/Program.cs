// A la linia 9 ens demana una lletra minuscula, a la linia 13 transforma converteix la lletra a numero,
// per convertir-la a majuscula hem de fer ascii - 32, i a la linia 15 convertir el numero a lletra.
// A l'ultima linia mostrem el resultat per pantalla.
//Declaracio variables
char minuscula, majuscula;
int ascii, asciiMaj;

//Entrada dades
Console.Write("Escriu una lletra minúscula: ");
minuscula = Convert.ToChar(Console.ReadLine());

//Algorisme
ascii = minuscula;
asciiMaj = ascii - 32;
majuscula = (char)asciiMaj;

//Sortida dades
Console.Clear();
Console.WriteLine($"La lletra en minúscula {minuscula}, en majúscula és {majuscula}");