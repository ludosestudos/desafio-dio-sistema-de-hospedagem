using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_dio_sistema_de_hospedagem.Models
{
    public class Suite
    {
        public string Tipo { get; set; }
        public double ValorDiaria { get; set; }

        public Suite(string tipo, double valorDiaria)
        {
            Tipo = tipo;
            ValorDiaria = valorDiaria;
        }
    }
}