using JHMESClient.Models.Base;
using JHMESClient.Models.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JHMESClient.Models
{

    public class BaseClass
    {
        [Column(TypeName = DatabaseDescription.ShortNvarchar50)]
        [DefaultValue("")]
        [Required]
        public string LastOperatorPosition { get; set; }

        [Column(TypeName = DatabaseDescription.LongNvarchar2000)]
        [Required]
        public string Remark { get; set; } = "1";

        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Required]
        [Column(TypeName ="datetime")]
        public DateTime CreatedTime { get; set; } //= DateTime.Now;
        private DateTime _ModifiedTime;
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime ModifiedTime 
        {
            set => _ModifiedTime = DateTime.Now;
            get => _ModifiedTime;
        }
        public DataStatus DataStatus { get; set; }
        [Column(TypeName = DatabaseDescription.ShortNvarchar50)]
        [DefaultValue("")]
        public string LastOperator { get; set; }
    }
}
