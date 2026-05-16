using System;

namespace ProyectoEmpleados
{
    public abstract class Empleado
    {
        // Propiedades
        public string Nombre { get; set; }
        public int ID { get; set; }
        public double SalarioBase { get; set; }

        // Métodos abstractos
        public abstract double CalcularSalarioAnual();

        public abstract void MostrarInformacion();
    }
}