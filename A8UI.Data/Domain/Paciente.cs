using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace A8UI.Data.Domain
{
    [Table("paciente")]
    public class Paciente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string  ApellidoMaterno { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string Status { get; set; }
    }
}
