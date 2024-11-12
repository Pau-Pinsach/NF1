//La linia 6 et demana l'edat i a la linia 10 calcula l'edat de l'any vinent. Fent l'operació {edat} + 1.

//Declaracio variables
int edat, anySeguent;

//Entrada dades
Console.WriteLine("Quants anys tens? ");
edat = Convert.ToInt32(Console.ReadLine());

//Algorisme
anySeguent = edat + 1;

//Sortida dades
Console.WriteLine($"Aquesy any tens {edat} anys." );
Console.WriteLine($"El pròxim any faràs {anySeguent} anys.");