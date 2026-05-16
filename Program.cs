using System;

namespace ProyectoEmpleados
{
    class Program
    {
        static void Main(string[] args)
        {
            // Objeto Gerente
            Gerente gerente1 = new Gerente
            {
                Nombre = "Carlos Mendoza",
                ID = 101,
                SalarioBase = 35000,
                BonoAnual = 15000
            };

            // Objeto Desarrollador
            Desarrollador desarrollador1 = new Desarrollador
            {
                Nombre = "Ana Lopez",
                ID = 102,
                SalarioBase = 28000,
                LenguajePrincipal = "C#"
            };

            // Objeto Contador
            Contador contador1 = new Contador
            {
                Nombre = "Luis Ramirez",
                ID = 103,
                SalarioBase = 25000,
                HorasExtras = 40,
                PagoPorHoraExtra = 200
            };

            // Mostrar información
            gerente1.MostrarInformacion();
            desarrollador1.MostrarInformacion();
            contador1.MostrarInformacion();

            Console.ReadKey();
        }
    }
}