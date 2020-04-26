using JHMESClient.Models.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JHMESClient.Models
{
    [Table("UserInfo")]
    public class UserInfo : BaseClass
    {
        [Key]
        public string UserGuid { get; set; }
        public string UserName { get; set; }
        public UserStatus UserStatus { get; set; }
        public string UserPosition { get; set; }
        public string EmployeeID { get; set; }
        public UserGroups UserGroups { get; set; }
    }
}
