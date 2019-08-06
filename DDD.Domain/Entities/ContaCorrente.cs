using System;

namespace DDD.Domain.Entities
{
    public class ContaCorrente : BaseEntity
    {

        public string Cpf { get; set;}
        public string Fone { get; set;}
        public string Endereco { get; set;}
        public string Saldo { get; set;}
        public string LimiteCredito { get; set;}

    }
}