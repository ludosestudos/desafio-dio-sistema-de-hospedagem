using System;
using desafio_dio_sistema_de_hospedagem.Models;
class Program
{
    static void Main(string[] args)
    {
        //Criando objetos Pessoa
        Pessoa p1 = new Pessoa("João", "12345678901");
        Pessoa p2 = new Pessoa("Maria", "23456789012");

        //Criando objetos Suite 
        Suite s1 = new Suite("Suíte Presidencial", 500.0);
        Suite s2 = new Suite("Suíte Luxo", 300.0);

        // Criando objeto Reserva 
        Reserva r1 = new Reserva(p1, s1, new DateTime(2023, 4, 1), new DateTime(2023, 4, 12));
        Reserva r2 = new Reserva(p2, s2, new DateTime(2023, 4, 11), new DateTime(2023, 4, 22));

        //Imprimindo informações das reservas 
        Console.WriteLine(r1);
        Console.WriteLine("Valor total da reserva: " + r1.ValorTotal().ToString("F2"));

        Console.WriteLine(r2);
        Console.WriteLine("Valor total da reserva: " + r2.ValorTotal().ToString("F2"));
        
    }
}
