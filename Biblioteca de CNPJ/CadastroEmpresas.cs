using System.ComponentModel.DataAnnotations;

namespace Biblioteca_de_CNPJ
{
    public class CadastroEmpresas
    {
        [MaxLength(14, ErrorMessage = "Campo CNPJ suporta no máximo 14 caracteres")]
        public string CNPJ {  get; set; }

        [MaxLength(45, ErrorMessage = "Campo Nome suporta no máximo 45 caracteres")]
        public string Nome { get; set; }

        [MaxLength(45, ErrorMessage = "Campo Código de Natureza Jurídica no Brasil suporta no máximo 5 caracteres")]

        public string CódigoDeNaturezaJurídica { get; set; }

        [MaxLength(45, ErrorMessage = "Campo Qualificação do Resposável suporta no máximo 200 caracteres")]

        public string QualificacaoDoResponsavel { get; set; }

        [MaxLength(45, ErrorMessage = "Capital Social da Empresa suporta no máximo 10 caracteres")]

        public int CapitalSocialDaEmpresa { get; set; }

        public int option = 1;

        public enum PorteDaEmpresa
        {
            NãoInformado,
            MicroEmpresa,
            EmpresaDePequenoPorte,
            Demais
        }


    }
}

