using System;
using System.ComponentModel.DataAnnotations;
using REYES_LabActivity1.Models;

namespace REYES_LabActivity1.Models
{
    public enum Hello
    {
        Instructor, AssistantProfessor, AssociateProfessor, Professor
    }
    public class Instructor
    {
        public int instructorID { get; set; }

        [Required(ErrorMessage = "First Name is required.")]
        public string instructorFirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required.")]
        public string instructorLastName { get; set; }

        [Required(ErrorMessage = "Tenure Status is required.")]
        public string instructorIsTenured { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string instructorEmail { get; set; }

        [Required(ErrorMessage = "Rank is required.")]
        public Hello instructorRank { get; set; }

        [Required(ErrorMessage = "Date Hired is required.")]
        public DateTime instructorDateHired { get; set; }
    }
}
