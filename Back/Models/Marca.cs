using System;
using System.Collections.Generic;

namespace Back.Models
{
    public class Marca
    {
        /// Properties
        
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Fabricante { get; set; }
        public string Representante { get; set; }
        public DateTime CreatedAt { get; set; }

        /// Constructor

        public Marca () => CreatedAt = DateTime.Now;

        /// Relations

        public ICollection<Modelo> Modelo { get; set; }
    } 
}