//

//Declaració variables
double eurosTotal;
int cent, cinquanta, vint, deu, cinc, dos, un, cinquantaCents, vintCents, deuCents, cincCents, dosCents, unCents;
int qUsuariCentims, pendentCanvi;
//Entrada dades
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.Write("Introdueix la quantitat d'euros: ");
eurosTotal = Convert.ToDouble(Console.ReadLine());
qUsuariCentims = (int)(eurosTotal * 100);
//Algorisme
cent = qUsuariCentims / 10000;
qUsuariCentims = qUsuariCentims % 10000;
cinquanta = qUsuariCentims / 5000;
qUsuariCentims = qUsuariCentims % 5000;
vint = qUsuariCentims / 200;
qUsuariCentims = vint % 200;
deu = qUsuariCentims / 10;
qUsuariCentims = deu % 10;
cinc = qUsuariCentims / 5;
qUsuariCentims = cinc % 5;
dos = qUsuariCentims / 2;
qUsuariCentims = dos % 2;
un = qUsuariCentims / 1;
qUsuariCentims = qUsuariCentims % 1;

//Sortida dades
Console.WriteLine($"{qUsuariCentims}");