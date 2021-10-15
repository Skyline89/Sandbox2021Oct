using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sandbox2021Oct.DataLayer.Context.Tables
{
    /// <summary>
    /// 
    /// </summary>
    [Table("role_permission")]
    public class RolePermission
    {
        [Key]
        public long Id { get; set; }

        [Column("role_id")]
        public long? RoleId { get; set; }

        [ForeignKey("RoleId")]
        public virtual Role Role { get; set; }

        [Column("permission_id")]
        public long? PermissionId { get; set; }

        [ForeignKey("PermissionId")]
        public virtual Permission Permission { get; set; }
    }
}
