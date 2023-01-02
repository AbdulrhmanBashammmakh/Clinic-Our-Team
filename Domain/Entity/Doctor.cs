using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Doctor
    {

        //ApplicationUser


        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;

      
        public string phone { get; set; }= string.Empty;
        public double fees { get; set; }
        public double contract_rate { get; set; }
        public string img_url { get; set; } = string.Empty;

        [ForeignKey("Specialty")]
        public int specialtyID { get; set; }


        public virtual Specialty Specialty { get; set; } = null;

    }
}
