using System;
using System.Collections.Generic;
using MRGGameTekRegistrationApi.Models;

namespace MRGGameTekRegistrationApi.Services
{
    public interface IAccounts<TEntity>
    {
        bool RegisterUser(TEntity entity);

        IList<TEntity> GetAllCustomerData();

        TEntity GetCustomerDataById(Guid id);

        bool UpdateCustomerData(TEntity entity);

        bool DeleteCustomerData(Guid id);

    }
}