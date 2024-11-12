namespace Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont, valor = 1;
            /*for (cont = 2; cont <= 40; cont += 2)
            {
                Console.WriteLine(cont);
            }*/
            for(cont = 1; cont <= 20; valor++)
            {
                if(valor % 2 == 0)
                {
                    Console.WriteLine(valor);
                    cont++;
                }
            }
        }
    }
}
