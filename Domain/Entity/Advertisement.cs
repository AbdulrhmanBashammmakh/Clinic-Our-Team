using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Advertisement
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [ForeignKey("Doctor")]
        public int DoctorID { get; set; }

        public string available_day { get; set; }=String.Empty;

        public DateTime from { get; set; }
        public DateTime To { get; set; }


        public virtual Doctor Doctor { get; set; } = null;

    }
}
