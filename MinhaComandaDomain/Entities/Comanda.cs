using System;

namespace MinhaComandaDomain.Entities
{
    class Comanda : Entidade
    {        
        public virtual Cliente Cliente { get; set; }        
        public virtual Estabelecimento Estabelecimento { get; set; }        
        public virtual Consumo Consumo { get; set; }
        public DateTime DataAtivacao { get; set; }
        public DateTime DataFechamento { get; set; }

    }
}
