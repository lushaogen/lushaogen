using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JHMESClient.Models
{
    [Table("R_RolePermission")]
    public class RolePermission
    {

        public long RoleID { get; set; }
        public virtual  Role Role { get; set; }
        public long PermissionId { get; set; }
        public virtual Permission permission { get; set; }
    }
}
