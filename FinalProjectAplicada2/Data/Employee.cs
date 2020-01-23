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
        
        [Required(ErrorMessage ="Este campo no puede estar vacio")]
        public string Nombres { get; set; }
        [Required(ErrorMessage ="Este campo no puede estar vacio")]
        public string Apellidos { get; set; }
        [Required(ErrorMessage = "Este campo no puede estar vacio")]
        public string Cedula { get; set; }
        [Required(ErrorMessage = "Este campo no puede estar vacio")]
        public string Nacionalidad { get; set; }
        [Required(ErrorMessage = "Este campo no puede estar vacio")]
        public string EstadoCivil { get; set; }
        [Required(ErrorMessage = "Este campo no puede estar vacio")]
        public DateTime FechaNacimiento { get; set; }
        [Required(ErrorMessage = "Este campo no puede estar vacio")]
        public decimal Salario { get; set; }
        [Required(ErrorMessage = "Este campo no puede estar vacio")]
        public DateTime FechaIngreso { get; set; }
        [Required(ErrorMessage = "Este campo no puede estar vacio")]
        public string Celular { get; set; }
        [Required(ErrorMessage = "Este campo no puede estar vacio")]
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
