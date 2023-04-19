namespace Persone
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //nome e cognome, data nascita, luogo nascita sesso ,eta
            var p = new Persona
            {
                Nome = "pino",
                Cognome = "Delillo",
                DataNascita = new DateTime(200, 5, 25),
                LugoNascita = "torino",
                Sesso = Sesso.M
            };
            Console.WriteLine(p);

        }
        }
    }