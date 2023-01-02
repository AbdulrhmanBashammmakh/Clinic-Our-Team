using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Prescribing
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string medician { get; set; }=string.Empty;
        public string note { get; set; } = string.Empty;
        [ForeignKey("Checked")]
        public int CheckedID { get; set; }

        public virtual Checked Checked { get; set; } = null;
    }
}
