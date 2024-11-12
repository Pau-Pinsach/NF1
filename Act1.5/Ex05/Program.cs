namespace Ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracio variables
            int numero, mitjana = 0, suma = 0, cont = 0;

            //Entrada dades
            Console.Write("Introdueix un número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            //Algorisme
            while (numero != 0)
            {
                cont++;
                suma = (numero + suma);
                mitjana = suma / cont;
                Console.Write("Introdueix un altre número: ");
                numero = Convert.ToInt32(Console.ReadLine());
            }

            //Sortida dades
            Console.WriteLine($"La mitjana dels números introduits és {mitjana}");
        }
    }
}
