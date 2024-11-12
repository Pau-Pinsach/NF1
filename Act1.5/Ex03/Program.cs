namespace Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracio variables
            int valor, contPositiu = 0, contNegatiu = 0;

            //Entrada dades
            Console.Write("Introdueix un valor: ");
            valor = Convert.ToInt32(Console.ReadLine());

            //Algorisme
            while (valor != 0)
            {
                if (valor < 0)
                    contNegatiu++;
                else contPositiu++;

                Console.Write("Escriu un altre valor: ");
                valor = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"Has introduit {contPositiu} positius i {contNegatiu} negatius.");
        }
    }
}
