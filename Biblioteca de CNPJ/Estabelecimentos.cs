using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_CNPJ
{
    public class Estabelecimentos
    {
        [MaxLength(45, ErrorMessage = "CNPJ Básico suporta no máximo 8 caracteres")]

        public string CnpjBasico { get; set; }

        [MaxLength(45, ErrorMessage = "CNPJ Ordem suporta no máximo 4 caracteres")]

        public string CnpjOrdem { get; set; }

        [MaxLength(45, ErrorMessage = "CNPJ DV suporta no máximo 2 caracteres")]

        public string CnpjDv { get; set; }

        public enum IdentificadorMatrizFilial  

        {
            Matriz,
            Filial
           
        }

        [MaxLength(45, ErrorMessage = "Nome Fantasia suporta no máximo 40 caracteres")]

        public string NomeFantasia { get; set; }

        public enum SitacaoCadastral

        {
            Nula,
            Ativa,
            Suspensa,
            Inapta
        }



        [MaxLength(45, ErrorMessage = "Data Sitação Cadastral suporta no máximo 10 caracteres")]

        public string DataSitacaoCadastral { get; set; }

        [MaxLength(45, ErrorMessage = "Motivo Sitação Cadastral suporta no máximo 50 caracteres")]

        public string MotivoSituacaoCadastral { get; set; }

        [MaxLength(45, ErrorMessage = "Nome da cidade no exterior suporta no máximo 50 caracteres")]

        public string NomeDaCidadeNoExterior { get; set; }

        [MaxLength(45, ErrorMessage = "País suporta no máximo 20 caracteres")]

        public string Pais {  get; set; }

        [MaxLength(45, ErrorMessage = "Data de início atividade suporta no máximo 10 caracteres")]

        public string DataDeInicioAtivade { get; set; }

        [MaxLength(45, ErrorMessage = "CNAE fiscal principal suporta no máximo 40 caracteres")]

        public string CnaeFiscalPrincipal { get; set; }

        [MaxLength(45, ErrorMessage = "CNAE fiscal secundária suporta no máximo 40 caracteres")]

        public string CnaeFiscalSecundaria { get; set; }

        [MaxLength(45, ErrorMessage = "Tipo de logradouro suporta no máximo 40 caracteres")]

        public string TipoDeLogradouro { get; set; }

        [MaxLength(45, ErrorMessage = " Logradouro suporta no máximo 40 caracteres")]

        public string Logradouro { get; set; }

        [MaxLength(45, ErrorMessage = " Número suporta no máximo 7 caracteres")]

        public string Numero { get; set; }

        [MaxLength(45, ErrorMessage = " Complemento suporta no máximo 40 caracteres")]

        public string Complemento { get; set; }

        [MaxLength(45, ErrorMessage = " Bairro suporta no máximo 40 caracteres")]

        public string Bairro { get; set; }

        [MaxLength(45, ErrorMessage = " CEP suporta no máximo 9 caracteres")]

        public string CEP { get; set; }

        [MaxLength(45, ErrorMessage = " UF suporta no máximo 10 caracteres")]

        public string UF { get; set; }

        [MaxLength(45, ErrorMessage = " Município suporta no máximo 40 caracteres")]

        public string Municipio { get; set; }

        [MaxLength(45, ErrorMessage = " DDD 1 suporta no máximo 10 caracteres")]

        public string DDD1 { get; set; }

        [MaxLength(45, ErrorMessage = " Telefone 1 suporta no máximo 20 caracteres")]

        public string Telefone1 { get; set; }

        [MaxLength(45, ErrorMessage = " DDD 2 suporta no máximo 10 caracteres")]

        public string DDD2 { get; set; }

        [MaxLength(45, ErrorMessage = " Telefone 2 suporta no máximo 20 caracteres")]

        public string Telefone2 { get; set; }

        [MaxLength(45, ErrorMessage = " DDD FAX suporta no máximo 10 caracteres")]

        public string DDDFAX { get; set; }

        [MaxLength(45, ErrorMessage = " FAX suporta no máximo 40 caracteres")]

        public string FAX { get; set; }

        [MaxLength(45, ErrorMessage = " Correio Eletrônico suporta no máximo 40 caracteres")]

        public string CorreioEletronico { get; set; }

        [MaxLength(45, ErrorMessage = " Situação Especial suporta no máximo 200 caracteres")]

        public string SitacaoEspecial { get; set; }

        [MaxLength(45, ErrorMessage = " Data da Situação Especial suporta no máximo 10 caracteres")]

        public string DataSitacaoEspecial { get; set; }
    }
}
