using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sandbox2021Oct.DataLayer.Context.Tables
{
    /// <summary>
    /// 
    /// </summary>
    [Table("accessed_candidate")]
    public class AccessedCandidate
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column("access_date")]
        public DateTime AccessDate { get; set; }

        [Required]
        [Column("candidate_id")]
        public int CandidateId { get; set; }

        [ForeignKey("CandidateId")]
        public virtual Candidate Candidate { get; set; }

        [Required]
        [Column("team_id")]
        public int TeamId { get; set; }

        [ForeignKey("TeamId")]
        public virtual Team Team { get; set; }

    }
}
