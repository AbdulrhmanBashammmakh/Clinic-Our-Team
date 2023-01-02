using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Checked
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [ForeignKey("Reception")]
        public int ReceptionID { get; set; }
        [ForeignKey("HealthRecord")]
        public int HealthRecordID { get; set; }

        public DateTime checked_date { get; set; }= DateTime.Now;

      
        public virtual Reception Reception { get; set; } = null;

        public virtual HealthRecord HealthRecord { get; set; } = null;
    }
}
