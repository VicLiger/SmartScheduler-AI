using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartScheduler.Domain.Models;

namespace SmartScheduler.Domain.Interfaces.Repository
{
    public interface IAvailabilityRepository
    {
        Task<Availability?> GetByIdAsync(Guid id);
        Task<IEnumerable<Availability>> GetAllAsync();
        Task AddAsync(Availability availability);
        Task UpdateAsync(Availability availability);
        Task DeleteAsync(Guid id);
    }
}
