﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BE.Seguimiento
{
    [Table("tblSeguimiento")]
    public class Seguimiento
    {
        public int SeguimientoId { get; set; }
        public int PersonaId { get; set; }
        public int EsEliminado { get; set; }
        public int? UsuGraba { get; set; }
        public DateTime? FechaGraba { get; set; }
        public int? UsuActualiza { get; set; }
        public DateTime? FechaActualiza { get; set; }
    }
}