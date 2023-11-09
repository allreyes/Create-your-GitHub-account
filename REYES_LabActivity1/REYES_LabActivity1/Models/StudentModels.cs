using System;
using System.ComponentModel.DataAnnotations;

namespace REYES_LabActivity1.Models
{
    public enum Course
    {
        BSIT, BSCS, BSIS, OTHER
    }

    public class Student
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "First Name is required.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "GPA is required.")]
        [Range(0.0, 4.0, ErrorMessage = "GPA must be between 0.0 and 4.0.")]
        public double GPA { get; set; }

        [Required(ErrorMessage = "Course is required.")]
        public Course Course { get; set; }

        [Required(ErrorMessage = "Admission Date is required.")]
        public DateTime AdmissionDate { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string Email { get; set; }
    }
}
