using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FinalProjectAplicada2.Data
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Cedula { get; set; }
        public string Nacionalidad { get; set; }
        public string EstadoCivil { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public decimal Salario { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string Celular { get; set; }
        public string Telefono { get; set; }
        public Employee()
        {
            EmployeeId = 0;
            Nombres = string.Empty;
            Apellidos = string.Empty;
            Cedula = string.Empty;
            FechaNacimiento = DateTime.Now;
            Nacionalidad = string.Empty;
            EstadoCivil = string.Empty;
            Salario = 0;
            FechaIngreso = DateTime.Now;
            Celular = string.Empty;
            Telefono = string.Empty;
        }
    }
}
