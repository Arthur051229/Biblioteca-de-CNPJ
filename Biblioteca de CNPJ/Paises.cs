using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_CNPJ
{
    public class Paises
    {
        [MaxLength(45, ErrorMessage = "Código do País no máximo 30 caracteres")]

        public string CodigoDoPais { get; set; }

        [MaxLength(45, ErrorMessage = "Nome do País suporta no máximo 50 caracteres")]

        public string NomeDoPais { get; set; }
    }
}
