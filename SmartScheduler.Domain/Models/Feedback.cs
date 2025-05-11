using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartScheduler.Domain.Models
{
    public class Feedback
    {
        public Guid Id { get; set; }

        public Guid AppointmentId { get; set; }
        public Appointment Appointment { get; set; } = null!;

        public int Rating { get; set; } // de 1 a 5
        public string? Comments { get; set; }
    }

}
