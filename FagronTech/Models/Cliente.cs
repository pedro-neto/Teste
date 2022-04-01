using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FagronTech.Models
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Idade { get; set; }
        public int Profissao { get; set; }
    }
    public class ClienteCompleto : Cliente
    {
        public int ID { get; set; }
    }
}
