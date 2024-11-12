namespace Ex16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracio variables
            int any;

            //Entrada dades
            Console.Write("Introdueix un any: ");
            any = Convert.ToInt32(Console.ReadLine());

            //Algorisme
            if (EsAnyFestivalBulukulu(any))
            {
                Console.WriteLine($"L'any {any} és festa bulukulu i any de traspàs.");
            }
            else if (EsAnyFestivalHulukulu(any))
            {
                Console.WriteLine($"L'any {any} és festa hulukulu.");
            }
            else if (EsAnyTraspas(any))
            {
                Console.WriteLine($"L'any {any} és de traspàs.");
            }
            else
                Console.WriteLine($"L'any {any} no és festiu ni de traspàs.");


        }
        static bool EsAnyTraspas(int any)
        {
            bool traspas;
            if (any % 4 == 0 && any % 100 != 0 || any % 400 == 0)
            {
                traspas = true;
            }
            else 
                traspas = false;
            return traspas;
        }
        static bool EsAnyFestivalHulukulu(int any)
        {
            bool hulukulu;
            if (any % 15 == 0)
            {
                hulukulu = true;
            }
            else
                hulukulu = false;
            return hulukulu;
        }
        static bool EsAnyFestivalBulukulu(int any)
        {
            bool bulukulu;
            if (any % 55 == 0 && EsAnyTraspas(any))
                bulukulu = true;
            else
                bulukulu = false;
            return bulukulu;
        }
    }
}
