using System;

namespace CredentialsManager.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creando una nueva persona
            Person p1 = new Person();
            p1.FirstName = "Adrian";
            p1.LastName = "Pedroza";

            //Datos de la persona
            Console.WriteLine("Person ({0})", p1.FullName);
            Console.WriteLine("FirstName: {0}", p1.FirstName);
            Console.WriteLine("LastName: {0}", p1.LastName);



            Console.ReadKey();
        }
    }
}
