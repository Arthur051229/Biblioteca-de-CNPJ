using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_CNPJ
{
    public class NaturezasJuridicas
    {
        [MaxLength(45, ErrorMessage = "Código da natureza jurídica suporta no máximo 40 caracteres")]

        public string CodigoNaturezaJuridica { get; set; }

        [MaxLength(45, ErrorMessage = "Nome da Natureza Jurídica suporta no máximo 40 caracteres")]

        public string NomeNaturezaJuridica { get; set; }
    }
}
