﻿using System.ComponentModel.DataAnnotations;

namespace Clinica.Models
{
    public class Remuneracion
    {
        public int Id { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 5)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 5)]
        public string Apellido { get; set; }


        [Required]
        [StringLength(25, MinimumLength = 5)]
        public string Cargo { get; set; }

        [Required]
        public string Monto { get; set; }


    }
}