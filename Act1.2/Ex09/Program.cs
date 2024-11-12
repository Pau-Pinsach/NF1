//A la linia 8 demana el numero de polzades que vol convertir a metres, després a la linia 12
//realitza el calcul (polzades*2.54)/100 , per ultim a la linia 17 mostra el resultat per pantalla.

//Declaracio varibles
double polzada, resultatMetres;
const double cm = 2.54;

//Entrada dades
Console.Write("Quantes polzades vols convertir a metres? ");
polzada = Convert.ToDouble(Console.ReadLine());

//Algorisme
resultatMetres = (polzada * cm) / 100;

//Sortida dades
Console.Clear();
Console.WriteLine($"{polzada} polzades en metres són {resultatMetres}");
