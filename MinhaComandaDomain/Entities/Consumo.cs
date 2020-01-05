
using System.Collections.Generic;
using System.Linq;

namespace MinhaComandaDomain.Entities
{
    class Consumo : Entidade
    {
        public Consumo()
        {
            Lancamentos = new List<Lancamento>();
        }
        public virtual IEnumerable<Lancamento> Lancamentos { get; set; }        
        public int QuantidadeItens { get => Lancamentos.Where(x => x.DataEstorno == null).Count();}
    }
}
