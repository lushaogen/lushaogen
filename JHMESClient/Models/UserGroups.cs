using DevExpress.DataAccess.Native.Sql;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JHMESClient.Models
{
    [Table("UserGroups")]
    public class UserGroups : BaseClass
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long UserGroupsID { set; get; }
        public string GroupName { get; set; }
        public bool IsDistribute { get; set; }
        public bool IsAdmin { get; set; }
        public IList<UserInfo> userInfos { get; set; }
    }
}
