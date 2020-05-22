using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MRGGameTekRegistrationApi.DataContext;
using MRGGameTekRegistrationApi.Models;

namespace MRGGameTekRegistrationApi.Services
{
    public class AccountsRepository<TEntity> : IAccounts<TEntity> where TEntity : Registration
    {
        private readonly MRGGameTekDataContext mrgGameTekDataContext;
        private DbSet<TEntity> dbSet;

        public AccountsRepository(MRGGameTekDataContext mrgGameTekDataContext)
        {
            this.mrgGameTekDataContext = mrgGameTekDataContext;
            this.dbSet = this.mrgGameTekDataContext.Set<TEntity>();
        }

        IList<TEntity> IAccounts<TEntity>.GetAllCustomerData()
        {
            return dbSet.ToList();
        }

        public TEntity GetCustomerDataById(Guid id)
        {
            return dbSet.Find(id);
        }

        public bool RegisterUser(TEntity entity)
        {
            try{
            entity.Id = Guid.NewGuid();
             dbSet.Add(entity);
             mrgGameTekDataContext.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public bool UpdateCustomerData(TEntity entity)
        {
            try{
                dbSet.Update(entity);
                 mrgGameTekDataContext.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        bool IAccounts<TEntity>.DeleteCustomerData(Guid id)
        {
            try{
                var customerDataById = GetCustomerDataById(id);
                if(customerDataById == null)
                {
                    return false;
                } 
                
                dbSet.Remove(customerDataById);
                 mrgGameTekDataContext.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}