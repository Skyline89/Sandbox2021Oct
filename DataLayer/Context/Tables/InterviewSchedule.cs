using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sandbox2021Oct.DataLayer.Context.Tables
{
    /// <summary>
    /// 
    /// </summary>
    [Table("interview_schedule")]
    public class InterviewSchedule
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column("interview_date")]
        public DateTime InterviewDate { get; set; }

        [Required]
        [Column("interview_time")]
        public DateTime InterviewTime { get; set; }

        [Column("candidate_id")]
        public int CandidateId { get; set; }

        [ForeignKey("CandidateId")]
        public virtual Candidate Candidate { get; set; }

        [Required]
        [Column("employee_id")]
        public int EmployeeId { get; set; }

        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }

    }
}
