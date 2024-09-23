using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_CNPJ
{
    public class CNAEs
    {
        [MaxLength(45, ErrorMessage = " Código da atividade econômica suporta no máximo 40 caracteres")]

        public string CodigoAtividadeEconomica { get; set; }

        [MaxLength(45, ErrorMessage = " Nome da atividade econômica suporta no máximo 40 caracteres")]

        public string NomeDaAtividadeEconomica { get; set; }
    }
}
