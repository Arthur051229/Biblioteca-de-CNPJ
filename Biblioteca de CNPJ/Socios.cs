using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_CNPJ
{
    public class Socios
    {
        
        [MaxLength(45, ErrorMessage = "CNPJ Básico suporta no máximo 8 caracteres")]

        public string CnpjBasico { get; set; }

        public enum IdentificadorDeSocio

        {
            PessoaJuridica,
            PessoaFisica,
            Estrangeiro
           

        }


        [MaxLength(45, ErrorMessage = "Nome do Sócio suporta no máximo 50 caracteres")]

        public string NomeDoSocio { get; set; }


        [MaxLength(45, ErrorMessage = " Cnpj do Sócio suporta no máximo 14 caracteres")]

        public string CnpjDoSocio { get; set; }


        [MaxLength(45, ErrorMessage = "Código de qualificação do Sócio suporta no máximo 20 caracteres")]

        public string CodigoQualificacaoDoSocio { get; set; }


        [MaxLength(45, ErrorMessage = "Data de entrada sociedade suporta no máximo 20 caracteres")]

        public string DataDeEntradaSociedade { get; set; }


        [MaxLength(45, ErrorMessage = " Código País do sócio estrangeiro suporta no máximo 30 caracteres")]

        public string CodigoPaisDoSocioEstrangeiro { get; set; }

        [MaxLength(45, ErrorMessage = "Número do CPF do Representante Legal suporta no máximo 30 caracteres")]

        public string CpfRepresentanteLegal { get; set; }

        [MaxLength(45, ErrorMessage = " Código da qualificação do representante legal suporta no máximo 30 caracteres")]

        public string CodigoDaQualificacaoDoRepresentanteLegal { get; set; }

        [MaxLength(45, ErrorMessage = " Faixa etária do sócio suporta no máximo 15 caracteres")]

        public string FaixaEtaria { get; set; }










    }
}

