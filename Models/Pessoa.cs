using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_dio_sistema_de_hospedagem.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }

        public Pessoa(string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;
        }
    }
}