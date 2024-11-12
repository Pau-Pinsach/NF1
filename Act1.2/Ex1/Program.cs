//La linia 4 donarà el número resultat sense decimals.
//La linia 6 donara el numero resultat amb la quantitat de zeros davant el numero resultat que hem posat dins els {}.
//Declaracio variables
int n = Convert.ToInt32(Console.ReadLine());
//Algorisme
n = n + 1;
//Sortida dades
Console.WriteLine($"HAS ENTRAT : {n - 1} I UN MÉS VAL {n}");
Console.WriteLine($"HAS ENTRAT : {n - 1:0000} I UN MÉS VAL {n:0000}");