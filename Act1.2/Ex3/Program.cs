//A la linia 7, 9, 11 ens demana les hores, els minuts i els segons. Amb aquestes dades calcula el temps total en segons.
//Declaracio variables
int hores, minuts, segons, totalSegons;

//Entrada dades
Console.Write("Hores: ");
hores = Convert.ToInt32(Console.ReadLine());
Console.Write("Minuts: ");
minuts = Convert.ToInt32(Console.ReadLine());
Console.Write("Segons: ");
segons = Convert.ToInt32(Console.ReadLine());

//Algorisme
totalSegons = hores * 3600;
totalSegons = minuts * 60;
totalSegons = segons + minuts + hores;

//Sortida dades
Console.Clear();
Console.WriteLine($"Temps total en segons: {totalSegons} ");