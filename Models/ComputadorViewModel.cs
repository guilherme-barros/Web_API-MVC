using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_API_MVC.Models
{
    public class ComputadorViewModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; } = string.Empty;
        public int? UsuarioId { get; set; }
    }
}