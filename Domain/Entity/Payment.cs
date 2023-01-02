using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Payment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int AppointmentID { get; set; }  

        public double fees { get; set; }

        public int employeeID { get; set; }


        public virtual Employee Employee { get; set; } = null;
        public virtual Appointment Appointment { get; set; } = null;


    }
}
