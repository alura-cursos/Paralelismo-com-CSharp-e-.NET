using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Core.Model
{
    public class ContaCliente
    {
        public string NomeCliente { get; set; }
        public List<Movimento> Movimentacoes { get; set; }
        public decimal Investimento { get; set; }
    }
}
