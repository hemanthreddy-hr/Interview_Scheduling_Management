using System.ComponentModel.DataAnnotations;

namespace InterviewSchedulingProject1.Models
{
    public class SaveInterviewTimings
    {
        public int? Candidateid { get; set; }
        [Required(ErrorMessage = "The Selection is required")]

        public bool? selected { get; set; }
        [Display(Name = "Company Name")]


        [MaxLength(1000)]

        
        public string? Company { get; set; }
        
        public System.DateTime? InterviewTiming { get; set; }
    }
}
