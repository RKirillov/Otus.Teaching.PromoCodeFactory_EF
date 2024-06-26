﻿using Otus.Teaching.PromoCodeFactory.Core.Abstractions.Repositories;
using Otus.Teaching.PromoCodeFactory.Core.Domain.Administration;
using Otus.Teaching.PromoCodeFactory.Core.Domain.PromoCodeManagement;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Otus.Teaching.PromoCodeFactory.DataAccess.Repositories
{
    public interface ICustomerRepository : IRepository<Customer, Guid>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task AddAsync(Customer entity, CancellationToken cancellationToken);
        Task<int> DeleteByIdAsync(Guid id, CancellationToken cancellationToken = default);
        Task<List<Customer>> GetByPreferences(string preferenceName, CancellationToken cancellationToken);
        void Update(Customer entity);
        Task<int> UpdateAsync(Customer entity, CancellationToken cancellationToken = default);
    }
}