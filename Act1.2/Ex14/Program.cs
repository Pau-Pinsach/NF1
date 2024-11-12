//A la linia 6 demana a l'usuari els segons totals que vol convertir a hores, minuts i segons. A les linies 
//11, 12 i 13 calcula les hores, els minuts i els segons, a la linia 16 mostra els resultats per pantalla.
//Declaracio variables
int segonsTotals, hores, minuts, segons;

//Entrada dades
Console.Write("Introdueix els segons: ");
segonsTotals = Convert.ToInt32(Console.ReadLine());

//Algorisme
hores = segonsTotals / 3600;
minuts = (segonsTotals % 3600) / 60;
segons = segonsTotals % 60;

//Sortida dades
Console.WriteLine($"{hores:00}:{minuts:00}:{segons:00}");