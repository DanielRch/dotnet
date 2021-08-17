using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace AdoteUmPet.Models
{
    public class Donos
    {
        public Donos()
        {

        }

        public string IdDono { get; set; }
        public string Nome { get; set; } = "";
        [Required(ErrorMessage = "Email é obrigatório")]
        [DataMember]
        public string Email { get; set; } = "";
        [Required(ErrorMessage = "Telefone é obrigatório")]
        [DataMember]
        public string Telefone { get; set; } = "";
        [Required(ErrorMessage = "Endereco é obrigatório")]
        [DataMember]
        public string Endereco { get; set; } = "";
        [Required(ErrorMessage = "Complemento é obrigatório")]
        [DataMember]
        public string Complemento { get; set; } = "";
        [Required(ErrorMessage = "Bairro é obrigatório")]
        [DataMember]
        public string Bairro { get; set; } = "";
        [Required(ErrorMessage = "Municipio é obrigatório")]
        [DataMember]
        public string Municipio { get; set; } = "";
        [Required(ErrorMessage = "UF é obrigatório")]
        [DataMember]
        public string UF { get; set; } = "";
        [Required(ErrorMessage = "CEP é obrigatório")]
        [DataMember]
        public string CEP { get; set; } = "";

    }
}
