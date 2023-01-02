using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Appointment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [ForeignKey("Patient")]
        public int patientID { get; set; }

        [ForeignKey("Doctor")]
        public int doctorID { get; set; }

        public DateTime appointment_day { get; set; }

        // public string status { get; set; }




        public virtual Doctor Doctor { get; set; } = null;

        public virtual Patient Patient { get; set; } = null;

    }
}
