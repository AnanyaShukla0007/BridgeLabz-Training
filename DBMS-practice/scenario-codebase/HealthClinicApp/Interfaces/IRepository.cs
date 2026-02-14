using System.Collections.Generic;

namespace HealthClinicApp.Interfaces
{
    /// <summary>
    /// Generic repository contract.
    /// Used mainly for testing and logging abstraction.
    /// </summary>
    public interface IRepository<T>
    {
        void Add(T entity);
        T GetById(int id);
        List<T> GetAll();
    }
}
