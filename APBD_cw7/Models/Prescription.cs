using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APBD_cw7.Models
{
    public class Prescription
    {

        [Key]

        public int IdPrescription { get; set; }
        [Required]
        [MaxLength(100)]
        public DateTime date { get; set; }
        [Required]
        [MaxLength(100)]
        public DateTime dueDate { get; set; }
        [Required]
        public int IdPatient { get; set; }
        [Required]
        public Patient patient { get; set; }
        [Required]
        public int IdDoctor { get; set; }
        [Required]
        public Doctor doctor { get; set; }
    }
}
