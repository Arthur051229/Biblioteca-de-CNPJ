using Biblioteca.Infrastrucure.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Infrastructure.Repositories
{
    public class CNAEsRepository : ICNAEsRepository
    {
        private readonly DataContext _context;

        public CNAEsRepository(DataContext context)
        {
            _context = context;
        }

        public void Add(CNAEs entity)
        {
            _context.Add(entity);
        }

        public void Delete(CNAEsRepository entity)
        {
            _context.Remove(entity);
        }

        public CNAEs GetById(long id)
        {
            return _context.CNAEs.FirstOrDefault(x => x.Id == id);
        }

        public CNAEs GetSingle(Expression<Func<CNAEs, bool>> expression)
        {
            return _context.CNAEs.FirstOrDefault(expression)
        }