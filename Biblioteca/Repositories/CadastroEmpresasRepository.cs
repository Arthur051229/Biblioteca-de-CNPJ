using Biblioteca.Infrastrucure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Domain;
using System.Linq.Expressions;


namespace Biblioteca.Infrastrucure.Repositories
{
    public class CadastroEmpresasRepository : ICadastroEmpresaRepository
    {
        private readonly DataContext _context;

        public CadastroEmpresasRepository(DataContext context)
        {
            _context = context;
        }

        public void Add(CadastroEmpresas entity)
        {
            _context.Add(entity);
        }

        public void Update(CadastroEmpresas entity)
        {
            _context.Update(entity);
        }

        public void Delete(CadastroEmpresas entity)
        {
            _context.Remove(entity);
        }

        public CadastroEmpresas GetByID(long id)
        {
            try
            {
                return _context.CadastroEmpresas.First(x => x.Id == id);
            }

            catch
            {
                return null;
            }
        }

        public IList<CadastroEmpresa> GetAll()
        {
            return _context.CadastroEmpresas.ToList();
        }

        public IList<CadastroEmpresas> GetAll(Expression<Func<CadastroEmpresas, bool>> expression)
        {
            return _context.CadastroEmpresas.Where(expression).ToList();
        }

        public void AddValidation(CadastroEmpresas entity)
        {
            throw new NotImplementedException();
        }
    }
}

