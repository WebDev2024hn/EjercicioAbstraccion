using System;

namespace ProyectoEmpleados
{
    public class Desarrollador : Empleado
    {
        // Propiedad adicional
        public string LenguajePrincipal { get; set; }

        // Implementación de métodos abstractos
        public override double CalcularSalarioAnual()
        {
            return SalarioBase * 12;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine("===== DESARROLLADOR =====");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Salario Base: {SalarioBase}");
            Console.WriteLine($"Lenguaje Principal: {LenguajePrincipal}");
            Console.WriteLine($"Salario Anual: {CalcularSalarioAnual()}");
            Console.WriteLine();
        }
    }
}