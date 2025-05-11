using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartScheduler.Domain.Models;

namespace SmartScheduler.Domain.Interfaces.Repository
{
    public interface ICategoryRepository
    {
        Task<ProfessionalCategory?> GetByIdAsync(Guid id);
        Task<IEnumerable<ProfessionalCategory>> GetAllAsync();
        Task AddAsync(ProfessionalCategory category);
        Task UpdateAsync(ProfessionalCategory category);
        Task DeleteAsync(Guid id);
    }

}
