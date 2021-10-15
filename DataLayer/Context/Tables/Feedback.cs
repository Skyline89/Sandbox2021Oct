using Sandbox2021Oct.DataLayer.Context.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sandbox2021Oct.DataLayer.Context.Tables
{
    /// <summary>
    /// 
    /// </summary>
    [Table("feedback")]
    public class Feedback
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime DateTime { get; set; }

        [Required]
        public FeedbackType Feedbacks { get; set; }

        public string DetailedFeedbacks { get; set; }

        [Column("employee_id")]
        public int EmployeeId { get; set; }

        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }

        [Column("candidate_id")]
        public int CandidateId { get; set; }

        [ForeignKey("CandidateId")]
        public virtual Candidate Candidate { get; set; }
    }
}
