﻿using System;
using Application.Interfaces.Repository;
using Domain.Common;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;

namespace Persistence.Repositories
{
    public class GenericRepository<T> : IGenericRepositoryAsync<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext _dbContext;

        public GenericRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<T> AddAsync(T entity)
        {
            await _dbContext.Set<T>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(Guid Id)
        {
            return await _dbContext.Set<T>().FindAsync(Id);
        }
    }
}

