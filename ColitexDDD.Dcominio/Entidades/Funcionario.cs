﻿namespace ColitexDDD.Dominio.Entidades
{
    public class Funcionario
    {
        public int Codigo { get; set; }
        public string Senha { get; set; }
        public int Cpf { get; set; }
        public string NomeCompleto { get; set; }
        public string EnderecoCompleto { get; set; }
        public string Email { get; set; }
        public int Telefone { get; set; }
    }
}
