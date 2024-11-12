//
//Declaració variables
int any, unitats, desenes, centenes, milers;

//Entrada dades
Console.Write("Any: ");
any = Convert.ToInt32(Console.ReadLine());

//Algorisme 
unitats = any % 10;
desenes = any % 100 / 10;
centenes = any / 100 % 10;
milers = any / 1000;
//Sortida dades
Console.WriteLine($"{milers}");
Console.WriteLine($"{centenes}");
Console.WriteLine($"{desenes}");
Console.WriteLine($"{unitats}");
