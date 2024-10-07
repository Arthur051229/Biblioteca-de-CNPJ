using Biblioteca.Domain;
using Microsoft.EntityFrameworkCore;

namespace OpenConnect.Infrastructure.Interfaces
{
    public interface IUnitOfWork
    {
        IEstabelecimentosRepository EstabelecimentosRepository { get; }
        ICNAEsRepository CNAEsRepository { get; }
        IDadosSimplesRepository DadosSimplesRepository { get; }
        ICadastroEmpresasRepository CadastroEmpresasRepository { get; }
        IMunicipiosRepository MunicipiosRepository { get; }
        void Detach<T>(T entity);
        bool SaveAll();
        DbContext GetContext();
    }
}

