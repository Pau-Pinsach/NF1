namespace Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracio variables
            int hores, minuts, segons, segonsTotal;
            //Entrada dades
            Console.Write("Hores: ");
            hores = Convert.ToInt32(Console.ReadLine());
            Console.Write("Minuts: ");
            minuts = Convert.ToInt32(Console.ReadLine());
            Console.Write("Segons: ");
            segons = Convert.ToInt32(Console.ReadLine());
            //Algorisme
            segonsTotal = SegonsTotal(hores, minuts, segons);
            //Sortida dades
            Console.Clear();
            Console.WriteLine($"{hores} hores, {minuts} minuts, {segons} segons, són {segonsTotal} segons en total.");
        }
        static int SegonsTotal(int hores, int minuts, int segons)
        {
            int horesSegons, minutsSegons, totalSegons;
            horesSegons = hores * 3600;
            minutsSegons = minuts * 60;
            totalSegons = horesSegons + minutsSegons + segons;
            return totalSegons;

        }
    }
}
