using System;

namespace ProyectoEmpleados
{
    public class Gerente : Empleado
    {
        // Propiedad adicional
        public double BonoAnual { get; set; }

        // Implementación de métodos abstractos
        public override double CalcularSalarioAnual()
        {
            return (SalarioBase * 12) + BonoAnual;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine("===== GERENTE =====");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Salario Base: {SalarioBase}");
            Console.WriteLine($"Bono Anual: {BonoAnual}");
            Console.WriteLine($"Salario Anual: {CalcularSalarioAnual()}");
            Console.WriteLine();
        }
    }
}