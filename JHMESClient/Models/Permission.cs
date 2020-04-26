using JHMESClient.Models.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JHMESClient.Models
{
    [Table("Permission")]
    public class Permission : BaseClass
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long PermissionId { get; set; }
        [MaxLength(120)]
        public string PermissionName { get; set; }
        [MaxLength(120)]
        public string PermissionCode { get; set; }
        [MaxLength(120)]
        public string PermissionAddress { get; set; }
        public PermissionType PermissionType { get; set; }
        public Permission Per_PermissionsID { get; set; }
        public virtual IList<RolePermission> RolePermission { get; set; }
    }
}
