using System;

namespace MinhaComandaDomain.Entities
{
    internal class Lancamento : Entidade
    {
        public Item Item { get; set; }
        public DateTime DataLancamento { get; set; }
        public DateTime? DataEstorno { get; set; }
    }
}