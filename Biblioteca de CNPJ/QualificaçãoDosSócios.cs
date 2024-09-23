using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_CNPJ
{
    public class QualificaçãoDosSócios
    {
        [MaxLength(45, ErrorMessage = "Código da qualificação do sócio suporta no máximo 30 caracteres")]

        public string CodigoDaQualificacaoDoSocio { get; set; }


        [MaxLength(45, ErrorMessage = "Nome da qualificação do sócio suporta no máximo 30 caracteres")]

        public string NomeQualificacaoSocio { get; set; }

    }
}
