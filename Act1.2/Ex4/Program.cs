// A les linies 7 i 9 demana els numeros. A la linia 13 fa el calcul i a la linia 18 dona el resultat per pantalla. Calcula l'equacio amb la x ja aillada.
//Declaracio variables
double a, b, resultat;

//Entrada dades
Console.Write("Primer número: ");
a = Convert.ToDouble(Console.ReadLine());
Console.Write("Segon número: ");
b = Convert.ToDouble(Console.ReadLine());

//Algorisme
resultat = -b / a;

//Sortida dades
Console.Clear();
Console.WriteLine($"Els coeficients són {a} i {b}");
Console.WriteLine($"El resultat de l'equació és {resultat:F2}");