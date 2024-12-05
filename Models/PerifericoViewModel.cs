using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_API_MVC.Models.Enuns;

namespace Web_API_MVC.Models
{
    public class PerifericoViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Marca { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public TipoPerifericoEnum TipoPeriferico { get; set; }
        public double Preco { get; set; }
        public int? ComputadorId { get; set; }
    }
}