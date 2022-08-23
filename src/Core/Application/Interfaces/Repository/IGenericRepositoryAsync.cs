using System;
using Domain.Common;

namespace Application.Interfaces.Repository
{
    public interface IGenericRepositoryAsync<T> where T : BaseEntity
    {
        Task<List<T>> GetAllAsync();
        Task<T> AddAsync(T entity);
    }
}

