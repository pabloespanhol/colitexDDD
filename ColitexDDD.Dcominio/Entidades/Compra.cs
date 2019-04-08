using System;

namespace ColitexDDD.Dcominio.Entidades
{
    public class Compra
    {
        public int Codigo { get; set; }
        public DateTime DataHora { get; set; }
        public int OrdemCompra { get; set; }
        public double ValorUnitario { get; set; }
        public int Estoque { get; set; }
    }
}
