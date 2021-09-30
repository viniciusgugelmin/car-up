using System;

namespace Back.Models
{
    public class Veiculo
    {  
        /// Properties
        
        public int Id { get; set; }
        public int ModeloId { get; set; }
        public string Nome { get; set; }
        public string Cor { get; set; }
        public string CombustivelPrincipal { get; set; }
        public DateTime CreatedAt { get; set; }

        /// Constructor

        public Veiculo() => CreatedAt = DateTime.Now;

        /// Relations

        public Modelo Modelo { get; set; }
    }
}