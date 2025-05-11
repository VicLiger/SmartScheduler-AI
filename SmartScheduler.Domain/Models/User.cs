using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartScheduler.Domain.Enums;

namespace SmartScheduler.Domain.Models
{
    public class User
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public UserRole Role { get; set; } // Professional ou Client
        public string? Phone { get; set; }

        public string? Location { get; set; }
        public string? Preferences { get; set; }

        // Segurança
        public string PasswordHash { get; set; } = null!; // Sempre armazenar o hash, nunca a senha pura
        public string? RecoveryEmail { get; set; } // Email alternativo para recuperação

        // Auditoria
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? LastAccessAt { get; set; }

        // Categoria (somente para profissionais)
        public Guid? CategoryId { get; set; }
        public ProfessionalCategory? Category { get; set; }

        // Relacionamentos
        public ICollection<Appointment> AppointmentsAsClient { get; set; } = new List<Appointment>();
        public ICollection<Appointment> AppointmentsAsProfessional { get; set; } = new List<Appointment>();
        public ICollection<Availability> Availabilities { get; set; } = new List<Availability>();
    }



}
