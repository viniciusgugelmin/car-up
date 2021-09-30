using System;
using System.Collections.Generic;

namespace Back.Models
{
    public class Vendedor
    {
        /// Properties
        
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }

        /// Constructor

        public Vendedor () => CreatedAt = DateTime.Now;
    } 
}