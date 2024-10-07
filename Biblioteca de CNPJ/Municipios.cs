using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_CNPJ
{
    public class Municipios
    {
        [MaxLength(45, ErrorMessage = "Código do Município suporta no máximo 50 caracteres")]

        public string CodigoDoMunicipio { get; set; }

        [MaxLength(45, ErrorMessage = "Nome do Município suporta no máximo 50 caracteres")]

        public string NomeDoMunicípio { get; set; }
    }
}
