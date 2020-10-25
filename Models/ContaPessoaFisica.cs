using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Financial.Models.Enum;

namespace Financial.Models
{
    public class ContaPessoaFisica : Conta
    {
        public string NomeCompleto { get; set; }
        public DateTime DataNascimento { get; set; }
        public string EstadoCivil { get; set; }
        public Documento Documento { get; set; }
        public Genero Genero { get; set; }
    }
}
