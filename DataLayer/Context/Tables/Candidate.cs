using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sandbox2021Oct.DataLayer.Context.Tables
{
    /// <summary>
    /// 
    /// </summary>
    [Table("candidate")]
    public class Candidate
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public DateTime DateTimeNow { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public int Status { get; set; }

        [Required]
        public string Country { get; set; }

        [Required]
        public string Contact { get; set; }

        [Required]
        public string LinkedinURL { get; set; }

        [Required]
        public string Skill { get; set; }

        //public ICollection<AccessedCandidate> AccessedCandidate { get; set; }
        public AccessedCandidate AccessedCandidate { get; set; }

        //public ICollection<InterviewSchedule> InterviewSchedule { get; set; }
        public InterviewSchedule InterviewSchedule { get; set; }

        public Feedback Feedback { get; set; }
    }
}
