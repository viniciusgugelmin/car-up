using System;
using System.Collections.Generic;

namespace Back.Models
{
    public class Modelo
    {  
        /// Properties
        
        public int Id { get; set; }
        public int MarcaId { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public string Versao { get; set; }
        public DateTime CreatedAt { get; set; }

        /// Constructor
        
        public Modelo () => CreatedAt = DateTime.Now;

        /// Relations

        public Marca Marca { get; set; }
        public ICollection<Veiculo> Veiculo { get; set; }
   } 
}