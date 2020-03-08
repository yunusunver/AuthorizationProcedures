using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using authorizationProcedures.Context;
using authorizationProcedures.Models;

namespace authorizationProcedures.Services
{
    public class companyService
    {
        //DI
        private AuthorizationProceduresDB _context;

        public companyService(AuthorizationProceduresDB context)
        {
            _context = context;
        }

        public List<Company> GetCompanies(Expression<Func<Company, bool>> where ,int offset,int limit){
            try
            {
               return _context.Company.Where(where).Skip(offset).Take(limit).ToList();
            }
            catch (System.Exception)
            {
                
                throw;
            }
        } 
    }
}