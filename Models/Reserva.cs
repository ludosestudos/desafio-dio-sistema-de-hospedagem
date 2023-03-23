using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_dio_sistema_de_hospedagem.Models
{
    public class Reserva
    {
        public Pessoa Hospede { get; set; }
        public Suite Suite { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }

        public Reserva(Pessoa hospede, Suite suite, DateTime dataEntrada, DateTime dataSaida)
        {
            Hospede = hospede;
            Suite = suite;
            DataEntrada = dataEntrada;
            DataSaida = dataSaida;
        }

        public int QuantidadeHospedes()
        {
            //Considerando que a quantidade de hóspedes é sempre 1 por padrão
            return 1;
        }

        public double ValorDiaria()
        {
            return Suite.ValorDiaria;
        }

        public int QuantidadeDias()
        {
            return (DataSaida - DataEntrada).Days;
        }

        public double ValorTotal()
        {
            double ValorTotal = ValorDiaria() *QuantidadeDias() * QuantidadeHospedes();
            //Concedendo desconto de 10% para reservas de mais de 10 dias
            if (QuantidadeDias() > 10)
            {
                ValorTotal *= 0.9;
            }  
            return ValorTotal;
        }

            public override string ToString()
            {
                return "Reserva de " + Hospede.Nome + " na " + Suite.Tipo + " - Entrada: " + DataEntrada.ToString("dd/MM/yyyy")
                 + " - Saída: " + DataSaida.ToString("dd/MM/yyy"); 
            }

        
    }
}