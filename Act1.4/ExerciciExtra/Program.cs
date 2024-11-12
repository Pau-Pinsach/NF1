namespace ExerciciExtra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracio variables
            int mes, any, diesMes;
            string nomMes;

            //Entrada dades
            Console.Write("Introdueix un mes: ");
            mes = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introdueix un any: ");
            any = Convert.ToInt32(Console.ReadLine());

            //Algorisme
            diesMes = DiesDelMes(mes, any);
            nomMes = NomDelMes(mes);
            //Sortida dades
            if (Validacio(mes, any))
            {
                Console.WriteLine($"Aquesta entrada és errònia.");
            }
            else
            {
                Console.WriteLine($"El mes {nomMes} de l'any {any} té {diesMes} dies.");
            }
        }
        static int DiesDelMes(int mes, int any)
        {
            int dia;
            if (mes == 2)
            {
                if (any % 4 == 0 && any % 100 != 0 || any % 400 == 0)
                {
                    dia = 29;
                }
                else
                    dia = 28;
            }
            else if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
            {
                dia = 30;
            }
            else
                dia = 31;

            return dia;
        }
        static bool Validacio(int mes, int any)
        {
            bool valid;
            if (mes <= 0 || mes > 12 || any < 1900)
            {
                valid = true;
            }
            else
                valid = false;

            return valid;

        }
        static string NomDelMes(int mes)
        {
            string nom;
            if (mes == 1)
                nom = "Gener";
            else if (mes == 2)
                nom = "Febrer";
            else if (mes == 3)
                nom = "Març";
            else if (mes == 4)
                nom = "Abril";
            else if (mes == 5)
                nom = "Maig";
            else if (mes == 6)
                nom = "Juny";
            else if (mes == 7)
                nom = "Juliol";
            else if (mes == 8)
                nom = "Agost";
            else if (mes == 9)
                nom = "Septembre";
            else if (mes == 10)
                nom = "Octubre";
            else if (mes == 11)
                nom = "Novembre";
            else
                nom = "Decembre";

            return nom;
        }
    }
}
