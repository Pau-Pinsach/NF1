namespace Ex09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracio variables
            int numero, aux, cont = 0;

            //Entrada dades
            Console.Write("Introdueix un número: ");
            numero = Convert.ToInt32(Console.ReadLine());
            aux = numero;

            //Algorisme
            while (aux != 0)
            {
                cont++;
                aux = aux / 10;
            }
            //Sortida dades
            Console.WriteLine($"El número {numero} té {cont} dígits.");
        }
    }
}
