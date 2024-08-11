using Ecommerce.Domain.Entities.Users;
using Ecommerce.SharedLib.Domain.Comman;
using Ecommerce.SharedLib.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Entities.Prescriptions
{
    public class Prescription : AduitEntity<int>
    {
        public int? UserID { get; set; }
        [MaxLength(200)]
        public string DoctorName { get; set; } = string.Empty;
        public DateTime? PrescriptionDate { get; set; }
        [MaxLength(200)]
        [DataType(DataType.ImageUrl)]
        public string PrescriptionImageURL { get; set; } = string.Empty;
        public PrescriptionStatus? Status { get; set; } 
        [ForeignKey(nameof(UserID))]
        public User User { get; set; } = default!;
    }

}
