namespace ColitexDDD.Dcominio.Entidades
{
    public class Produtos
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double ValorUnitario  { get; set; }
        public int QtdEstoque { get; set; }
        public int Observacao { get; set; }
        public bool Ativo { get; set; }
    }
}
