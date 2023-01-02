using Domain.Entity;
using Infrastructure.ViewModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class ApplicationDbContext: IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public virtual DbSet<Advertisement> Advertisements { get; set; } = null!;
        public virtual DbSet<Appointment> Appointments { get; set; } = null!;
        public virtual DbSet<Checked> Checkeds { get; set; } = null!; 
        public virtual DbSet<Doctor> Doctors { get; set; } = null!;
        public virtual DbSet<DoctorReport> DoctorReports { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;

        public virtual DbSet<Examination> Examinations { get; set; } = null!;

        public virtual DbSet<HealthRecord> HealthRecords { get; set; } = null!;
        public virtual DbSet<Patient> Patients { get; set; } = null!;

        public virtual DbSet<Payment> Payments { get; set; } = null!;

        public virtual DbSet<Prescribing> Prescribings { get; set; } = null!;

        public virtual DbSet<Reception> Receptions { get; set; } = null!;

        public virtual DbSet<Specialty> Specialties { get; set; } = null!;


    }
}