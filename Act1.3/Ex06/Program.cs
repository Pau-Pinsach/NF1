namespace Ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracio variables
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int hores, souBrutHora, impost, souBrutTotal, retencio, souNet;
            //Entrada dades
            Console.Write("Hores totals treballades: ");
            hores = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sou brut per hora: ");
            souBrutHora = Convert.ToInt32(Console.ReadLine());
            Console.Write("Percentatge d'impost aplicat al sou brut total: ");
            impost = Convert.ToInt32(Console.ReadLine());
            //Algorisme
            souBrutTotal = SouBrut(hores, souBrutHora);
            retencio = Retencio(impost, souBrutTotal);
            souNet = SouNet(souBrutTotal, retencio);
            //Sortida dades
            Console.Clear();
            Console.WriteLine($"El sou brut total és {souBrutTotal}€");
            Console.WriteLine($"La retencio d'impostos és {retencio}€");
            Console.WriteLine($"El sou net és {souNet}€");

        }
        static int SouBrut(int hores, int souBrutHora)
        {
            int souBrutTotal;
            souBrutTotal = hores * souBrutHora;
            return souBrutTotal;
        }
        static int Retencio(int impost, int souBrutTotal)
        {
            int retencio;
            retencio = impost * souBrutTotal / 100;
            return retencio;
        }
        static int SouNet(int souBrutTotal, int retencio)
        {
            int souNet;
            souNet = souBrutTotal- retencio;
            return souNet;
        }
    }
}
