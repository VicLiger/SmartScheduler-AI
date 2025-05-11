using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartScheduler.Domain.Models
{
    public class Appointment
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; } // Cliente
        public User User { get; set; } = null!;

        public Guid ProfessionalId { get; set; } // Profissional
        public User Professional { get; set; } = null!;

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public string Status { get; set; } = "pendente"; // "pendente", "confirmado", "cancelado"
        public string Location { get; set; } = "online"; // "presencial" ou "online"

        public Feedback? Feedback { get; set; }
    }
}
