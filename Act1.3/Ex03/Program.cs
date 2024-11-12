namespace Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracio variables
            char minuscula, majuscula;
            //Entrada dades
            Console.Write("Una lletra minúscula: ");
            minuscula = Convert.ToChar(Console.ReadLine());
            //Algorisme
            majuscula = MinusculaMajuscula(minuscula);
            //Sortida dades
            Console.Clear();
            Console.WriteLine($"La lletra {minuscula} en majuscula és {majuscula}");
        }
        static char MinusculaMajuscula(char min)
        {
            char maj;
            int minNumero, majNumero;
            minNumero = (int)min;
            majNumero = minNumero - 32;
            maj = (char)majNumero;
            return maj;
        }
    }
}
