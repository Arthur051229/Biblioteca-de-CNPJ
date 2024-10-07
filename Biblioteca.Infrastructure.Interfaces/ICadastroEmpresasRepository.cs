using Biblioteca
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Biblioteca.Infrastructure.Interfaces
{
    public interface ICadastroEmpresasRepository : IRepository<CadastroEmpresas>
    {
        CadastroEmpresas GetById(long id);

        CadastroEmpresas GetSingle(Expression<Func<CadastroEmpresas, bool>> expression);

        IList<CadastroEmpresas> GetAll();

        IList<CadastroEmpresas> GetAll(Expression<Func<CadastroEmpresas, bool>> expression);

        void AddValidation(CadastroEmpresas entity);
    }
}
