using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UHRMS.Models
{
    public class CheckInForm
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CheckInId { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

        [Required]
        public Dorm Dorm { get; set; }

        [Required]
        public Room Room { get; set; }

        [Required]
        public DateTime CheckInDate { get; set; }

        [Required]
        public string StudyDesk { get; set; }

        [Required]
        public string Chairs { get; set; }

        [Required]
        public string Bulb { get; set; }

        [Required]
        public string Closet { get; set; }

        [Required]
        public string Door { get; set; }

        [Required]
        public string Dresser { get; set; }

        [Required]
        public string Bed { get; set; }

        [Required]
        public string LightSwitch { get; set; }

        [Required]
        public string Mattress { get; set; }

        [Required]
        public string Windows { get; set; }
    }
}