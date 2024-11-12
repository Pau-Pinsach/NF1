//A la linia 7 es crea la classe Random, a la linia 10 es calcula un numero aleatori del 65 al 90. 
//A la linia 11 s'utilitza un casting per convertir el numero aleatori a lletra, a la linia 14 es mostra el resultat per pantalla.
//Declaracio variables
int numeroAleatori;
char lletraMaj;
//Entrada dades
Random random = new Random();

//Algorisme
numeroAleatori = random.Next(65, 91);
lletraMaj = (char)numeroAleatori;

//Sortida dades
Console.WriteLine(lletraMaj);