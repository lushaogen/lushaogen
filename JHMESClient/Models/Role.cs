using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JHMESClient.Models
{
    [Table("Role")]
    public class Role : BaseClass
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long RoleID { get; set; }
        public string RoleName { get; set; }
        public string RoleDescription { get; set; }
        public bool IsDistribution { get; set; }
        public Role Pre_Role { get; set; }
        public virtual IList<RolePermission> RolePermission { get; set; }
    }
}
