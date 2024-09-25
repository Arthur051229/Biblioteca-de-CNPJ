using Biblioteca.Infrastructure;
using Microsoft.EntityFrameworkCore;
//using
//using


namespace Biblioteca.Infrastrucure.Core
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ICadastroEmpresasRepository _tcCadastroEmpresasRepository;
        private readonly ICNAEsRepository _tcCNAEsRepository;
        private readonly IDadosSimplesRepository _tcDadosSimplesRepository;
        private readonly IEstabelecimentosRepository _tcEstabelecimentosRepository;
        private readonly IMunicípiosRepository _tcMunicípiosRepository;
        private readonly IPaísesRepository _tcPaísesRepository;
        private readonly IQualificacaoDosSóciosRepository _tcQualificacaoDosSóciosRepository;
        private readonly ISociosRepository _tcSociosRepository;

        public UnitOfWork()
        {
            _context = new DataContext();
        }

        public DbContext GetDbContext()
        {
            return _context;
        }

        public ICadastroEmpresasRepository CadastroEmpresasRepository => _CadastroEmpresasRepository ?? new CadastroEmpresasRepository(_context);

        public ICNAEsRepository CNAEsRepository => _CNAEsRepository ?? new CNEsRepository(_context);

        public IDadosSimplesRepository DadosSimplesRepository => _DadosSimplesRepository ?? new DadosSimplesRepository(_context);

        public IEstabelecimentosRepository EstabelecimentosRepository => _EstabelecimentosRepository ?? new EstabelecimentosRepository(_context);

        public IMunicípiosRepository MunicípiosRepository => _MunicípiosRepository ?? new MunicípiosRepository(_context);

        public INaturezasJurídicasRepository NaturezasJurídicasRepository => _NaturezasJurídicasRepository ?? new NaturezasJurídicasRepository(_context);

        public IPaísesRepository PaísesRepository => _PaísesRepository ?? new PaísesRepository(_context);

        public ISóciosRepository SóciosRepository => _SóciosRepository ?? new SóciosRepository(_context);
        public IQualificacaoDosSóciosRepository QualificacaoDosSóciosRepository => _Qualificacao(_context);

        public void Detach<T>(T entity)
        {
            _context.Entry(entity).State = EntityState.Detached;
        }

        public bool SaveALL()
        {
            try
            {
                _context.Validate();
                return _context.SaveChanges() > 0;
            }
            catch (DbUpdateException ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}