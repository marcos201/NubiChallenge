﻿using Microsoft.EntityFrameworkCore;
using NubiChallengeApi.Core.Interfaces.Repositories;
using NubiChallengeApi.Core.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NubiChallengeApi.Data.Repositories
{
    public abstract class EfRepository<T> : IRepository<T> where T : BaseEntity
    {
        protected readonly NubiChallengeContext _nubiChallengeContext;

        protected EfRepository(NubiChallengeContext nubiChallengeContext)
        {
            _nubiChallengeContext = nubiChallengeContext;
        }

        public virtual async Task<T> GetById(Guid id)
        {
            return await _nubiChallengeContext.Set<T>().FindAsync(id);
        }

        public async Task<List<T>> ListAll()
        {
            return await _nubiChallengeContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetSingleBySpec(ISpecification<T> spec)
        {
            var result = await List(spec);
            return result.FirstOrDefault();
        }

        public async Task<List<T>> List(ISpecification<T> spec)
        {
            // fetch a Queryable that includes all expression-based includes
            var queryableResultWithIncludes = spec.Includes
                .Aggregate(_nubiChallengeContext.Set<T>().AsQueryable(),
                    (current, include) => current.Include(include));

            // modify the IQueryable to include any string-based include statements
            var secondaryResult = spec.IncludeStrings
                .Aggregate(queryableResultWithIncludes,
                    (current, include) => current.Include(include));

            // return the result of the query using the specification's criteria expression
            return await secondaryResult
                            .Where(spec.Criteria)
                            .ToListAsync();
        }


        public async Task<T> Add(T entity)
        {
            _nubiChallengeContext.Set<T>().Add(entity);
            await _nubiChallengeContext.SaveChangesAsync();
            return entity;
        }

        public async Task Update(T entity)
        {
            _nubiChallengeContext.Entry(entity).State = EntityState.Modified;
            await _nubiChallengeContext.SaveChangesAsync();
        }

        public async Task Delete(T entity)
        {
            _nubiChallengeContext.Set<T>().Remove(entity);
            await _nubiChallengeContext.SaveChangesAsync();
        }
    }
}
