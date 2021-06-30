using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace A8UI.Data.Domain
{
    [Table("paciente")]
    public class Paciente
    {
        [Key]
        [Column("id", TypeName ="int")]
        public int Id { get; set; }
        [Column("nombre", TypeName ="varchar(100)")]
        public string Nombre { get; set; }
        [Column("apellidopaterno", TypeName ="varchar(255)")]
        public string ApellidoPaterno { get; set; }
        [Column("apellidomaterno", TypeName ="varchar(255)")]
        public string  ApellidoMaterno { get; set; }
        [Column("fechanacimiento", TypeName ="datetime")]
        public DateTime FechaNacimiento { get; set; }
        [Column("fechaingreso", TypeName = "datetime")]
        public DateTime FechaIngreso { get; set; }
        [Column("status", TypeName = "varchar(3)")]
        public string Status { get; set; }
    }
}
