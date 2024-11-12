namespace Ex07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracio variables
            int numero, numMajor, numMenor;

            //Entrada dades
            Console.Write("Escriu un numero: ");
            numero = Convert.ToInt32(Console.ReadLine());
            numMajor = numero;
            numMenor = numero;

            //Algorisme
            while (numero != 0)
            {
                if (numMajor < numero)
                    numMajor = numero;
                else if (numMenor > numero)
                    numMenor = numero;
            }

            //Sortida dades
        }
    }
}
