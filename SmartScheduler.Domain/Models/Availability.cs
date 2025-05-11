using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartScheduler.Domain.Models
{
    public class Availability
    {
        public Guid Id { get; set; }

        public Guid ProfessionalId { get; set; }
        public User Professional { get; set; } = null!;

        public DayOfWeek DayOfWeek { get; set; } // Enum do .NET
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
    }
}
