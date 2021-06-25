﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace A8UI.Data.Domain
{
    [Table("users")]
    public class Users
    {
        [Key]
        [Column("id",TypeName ="varchar(255)")]
        public int Id { get; set; }
        [Column("nombre", TypeName ="varchar(255)")]
        public string Nombre { get; set; }
        [Column("email", TypeName ="varchar(255)")]
        public string Email { get; set; }
        [Column("apellido_paterno", TypeName ="varchar(255)")]
        public string ApellidoPaterno { get; set; }
        [Column("apellido_materno", TypeName = "varchar(255)")]
        public string ApellidoMaterno { get; set; }
        [Column("contraseña", TypeName = "varchar(100)")]
        public string Contraseña { get; set; }
        [Column("status", TypeName = "varchar(2)")]
        public string Status { get; set; }

    }

}
