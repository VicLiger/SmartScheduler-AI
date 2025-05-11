using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartScheduler.Domain.Models;

namespace SmartScheduler.Domain.Interfaces.Repository
{
    public interface IFeedbackRepository
    {
        Task<Feedback?> GetByIdAsync(Guid id);
        Task<IEnumerable<Feedback>> GetAllAsync();
        Task AddAsync(Feedback feedback);
        Task UpdateAsync(Feedback feedback);
        Task DeleteAsync(Guid id);
    }

}
