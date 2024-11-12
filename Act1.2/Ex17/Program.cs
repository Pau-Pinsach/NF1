//A la linia 7 demana al usuari les cares que te el dau, a la linia 9 creem la classe Random,
//a la linia 12 fa el calcul del resultat del dau i a la linia 15 mostra el resultat per pantalla.
//Declaració variables
int caresDau, resultatDau;

//Entrada dades
Console.Write("Quantes cares té el dau? ");
caresDau = Convert.ToInt32(Console.ReadLine());
Random random = new Random();

//Algorisme
resultatDau = random.Next(1, caresDau + 1);

//Sortida dades
Console.WriteLine($"Aquest ha sigut el resultat del dau: {resultatDau}");
