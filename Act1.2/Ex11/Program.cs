//A les linies 7, 9 i 11 demana el total d'hores, el sou brut per hora i el percentatge d'impost.
//A les linies 16, 17 i 18 fa els calculs per els 3 valors. A les linies 22, 23 i 24 mostra els resultats per pantalla.
//Declaracio variables
double horesTreball, souHora, percentatgeImpost;
double souBrut, retencioImpostos, souNet;

//Entrada dades
Console.Write("Total d'hores treballades: ");
horesTreball = Convert.ToDouble(Console.ReadLine());
Console.Write("Sou brut per hora: ");
souHora = Convert.ToDouble(Console.ReadLine());
Console.Write("Percentatge de l'impost aplicat al sou brut total: ");
percentatgeImpost = Convert.ToDouble(Console.ReadLine());

//Algorisme
souBrut = horesTreball * 4.3 * souHora;
retencioImpostos = souBrut * percentatgeImpost / 100;
souNet = souBrut - retencioImpostos;

//Sortida dades
Console.Clear();
Console.WriteLine($"El sou brut total és {souBrut}");
Console.WriteLine($"La part de retenció d'impostos és {retencioImpostos}");
Console.WriteLine($"El sou net és {souNet}");