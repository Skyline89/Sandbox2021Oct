using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sandbox2021Oct.DataLayer.Context.Tables
{
    /// <summary>
    /// 
    /// </summary>
    [Table("permission")]
    public class Permission
    {
        [Key]
        public long Id { get; set; }

        public string Name { get; set; }

        public string Key { get; set; }
    }
}
