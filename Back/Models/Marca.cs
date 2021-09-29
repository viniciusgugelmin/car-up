using System;
namespace Back.Models
{
    public class Marca
    {
        /// Properties
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreatedAt { get; set; }

        /// Constructor

        public Marca () => CreatedAt = DateTime.Now;
    } 
}