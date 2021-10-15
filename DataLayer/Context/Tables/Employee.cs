using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Sandbox2021Oct.DataLayer.Context.Tables
{
    /// <summary>
    /// 
    /// </summary>
    [Table("employee")]
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [JsonIgnore]
        public string Email { get; set; }

        [JsonIgnore]
        [Column("hash_password")]
        public virtual string HashPassword { get; set; }

        [JsonIgnore]
        [Column("salt")]
        public virtual string Salt { get; set; }

        [Column("role_id")]
        public long? RoleId { get; set; }

        [ForeignKey("RoleId")]
        public virtual Role Role { get; set; }

        public ICollection<InterviewSchedule> InterviewSchedules { get; set; }

        public ICollection<Feedback> Feedbacks { get; set; }

        public ICollection<Team> Teams { get; set; }

    }
}
