using Dapper.Contrib.Extensions;
using Desafio.Domain.Interfaces;
using Desafio.Domain.Model;
using Desafio.Service.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.Service.Repository
{
    public class SubscribeRepository : ISubscribe
    {
        IDbConnection _connection;
        ContextDb _context;

        public SubscribeRepository(IDbConnection connection, ContextDb context)
        {
            _connection = connection;
            _context = context;
        }

        public async Task Insert(Subscribe sub)
        {
            try
            {
                _context.Entry(sub).State = EntityState.Added;
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task Update(Subscribe sub)
        {
            try
            {
                _context.Entry(sub).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task Delete(Subscribe sub)
        {
            try
            {
              _context.Remove(sub);
              await _context.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<Subscribe> Get(int id)
        {
            try
            {
                return await _context.Subscribe.Where(c => c.Id == id).SingleOrDefaultAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<IEnumerable<Subscribe>> GetAll()
        {
            try
            {
                return await _context.Subscribe.ToListAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<Subscribe> Verification(string email)
        {
            try
            {
                return await _context.Subscribe.Where(c => c.Email == email).SingleOrDefaultAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> Exists(int id)
        {
            try
            {
                return await _context.Subscribe.Where(c => c.Id == id).AnyAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
