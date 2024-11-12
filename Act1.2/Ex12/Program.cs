//Aquest programa serveix per intercanviar els valors de posicio.
//Declaració variables
int a, b, c;

//Entrada dades
Console.Write("Dona un valor a la variable a: ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Dona un valor a la variable b: ");
b = Convert.ToInt32(Console.ReadLine());

//Algorisme
c = a;
a = b;
b = c;

//Sortida dades
Console.WriteLine(a);
Console.WriteLine(b);
