﻿namespace JobLeet.WebApi.JobLeet.Core.Interfaces
{
    /// <summary>
    /// Generic repository interface for basic CRUD operations.
    /// </summary>
    /// <typeparam name="T">The entity type.</typeparam>
    public interface IRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(int id);
    }
}
