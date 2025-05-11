using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartScheduler.Domain.Models
{
    public class ProfessionalCategory
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public ICollection<User> Professionals { get; set; } = new List<User>();
    }
}
