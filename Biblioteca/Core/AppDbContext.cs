using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Biblioteca.Domain;
using Microsoft.Extensions.Options;



namespace Biblioteca.Infrastrucure.Core
{
    public partial class DataContext : DbContext
    {
        public DataContext() { }

        public DataContext(DbContextOptions<DataContext> options)
          : base(options) { }

        public DbSet<CadastroEmpresas> CadastroEmpresas { get; set; }
        public DbSet<CNAEs> CNAEs { get; set; }
        public DbSet<DadosSimples> DadosSimples { get; set; }
        public DbSet<Estabelecimentos> Estabelecimentos { get; set; }
        public DbSet<Municípios> Municípios { get; set; }
        public DbSet<NaturezasJurídicas> NaturezasJurídicas { get; set; }
        public DbSet<Países> Países { get; set; }
        public DbSet<QualificacaoDosSócios> QualificacaoDosSócios { get; set; }

    }
}











