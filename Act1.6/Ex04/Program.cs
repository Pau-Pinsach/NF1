namespace Ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracio variables
            int inici, final;

            //Entrada dades
            Console.Write("Entra el primer valor: ");
            inici = Convert.ToInt32(Console.ReadLine());
            Console.Write("Entra el segon valor: ");
            final = Convert.ToInt32(Console.ReadLine());

            //algorisme
            for (int cont = inici; cont <= final; cont++)
            {
                if (cont % 7 == 1)
                {
                    Console.WriteLine(cont);
                }
            }
        }
    }
}
