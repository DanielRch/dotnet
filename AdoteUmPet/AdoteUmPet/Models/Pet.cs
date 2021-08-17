using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdoteUmPet.Models
{
    public class Pet
    {
        public Pet(string id, string tipo, string raca, int idade)
        {
            Id = id;
            Tipo = tipo;
            Raca = raca;
            Idade = idade;
        }

        public string Id { get; set; }

        [Required(ErrorMessage = "Tipo é obrigatório")]
        public string Tipo { get; set; }
        [Required (ErrorMessage = "Raça é obrigatório")]
        public string Raca { get; set; }
        [Required (ErrorMessage = "Idade é obrigatório")]
        public int Idade { get; set; }
        [Required (ErrorMessage = "Porte é obrigatório")]
        public string Porte { get; set; }
        [Required (ErrorMessage = "Peso é obrigatório")]
        public double Peso { get; set; }

    }
}
