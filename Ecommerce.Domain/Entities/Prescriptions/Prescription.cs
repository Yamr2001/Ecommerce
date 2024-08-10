using Ecommerce.Domain.Entities.Users;
using Ecommerce.SharedLib.Domain.Comman;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Entities.Prescriptions
{
    public class Prescription : AduitEntity<int>
    {
        public int UserID { get; set; }
        public string DoctorName { get; set; }
        public DateTime PrescriptionDate { get; set; }
        public string PrescriptionImageURL { get; set; }
        public string Status { get; set; } // e.g., Pending, Approved, Rejected

        public User User { get; set; } = default!;
    }

}
