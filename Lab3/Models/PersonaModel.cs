using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace WebApplication1.Models
{
    public class PersonaModel
    {
        public string Nombre { get; set; }
        public int Id { get; set; }
        public double Peso { get; set; }
        public double Estatura { get; set; }
        public PersonaModel(int id, string nombre, double peso, double estatura)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Peso = peso;
            this.Estatura = estatura;
        }
    }
}
