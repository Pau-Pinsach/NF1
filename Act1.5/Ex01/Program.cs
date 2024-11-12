namespace Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracio variables
            int valor, cont = 1;

            //Entrada dades
            Console.Write("Introdueix un valor: ");
            valor = Convert.ToInt32(Console.ReadLine());

            //Algorisme
            while (valor != 0)
            {
                cont++;
                Console.Write("Introdueix un altre valor: ");
                valor = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"Has introduit {cont} valors fins introduir el 0");
        }
    }
}
