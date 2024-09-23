using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_CNPJ
{
    public class DadosSimples
    {
        [MaxLength(45, ErrorMessage = " CNPJ Básico suporta no máximo 40 caracteres")]

        public string CnpjBasico { get; set; }

        public enum PorteDaEmpresa
        {
            SIM,
            NÃO,
            OUTROS
            
        }

        [MaxLength(45, ErrorMessage = " Data de opção pelo simples suporta no máximo 40 caracteres")]

        public string DataDeOpcaoPeloSimples { get; set; }

        [MaxLength(45, ErrorMessage = " Data de exclusão do simples suporta no máximo 40 caracteres")]

        public string DataDeExclusaoDoSimples { get; set; }

        [MaxLength(45, ErrorMessage = " Opção pelo MEI suporta no máximo 40 caracteres")]

        public string OpcaoPeloMei { get; set; }

        [MaxLength(45, ErrorMessage = " Data de Exclusão do MEI suporta no máximo 40 caracteres")]

        public string DataDeExclusãoDoMei { get; set; }
    }
}
