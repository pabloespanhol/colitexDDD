namespace ColitexDDD.Dcominio.Entidades
{
    public class Produtores
    {
        public int Codigo { get; set; }
        public string Senha { get; set; }
        public int Cnpj { get; set; }
        public  string RazaoSocial  { get; set; }
        public string EnderecoCompleto { get; set; }
        public string Email { get; set; }
        public int Telefone { get; set; }
        public bool Situacao { get; set; }

    }
}
