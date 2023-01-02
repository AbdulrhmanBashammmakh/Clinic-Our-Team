using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Patient
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string FullName { get; set; }=string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;

        public DateTime birthday { get; set; }
        public int Age { get; set; }

        

    }
}
