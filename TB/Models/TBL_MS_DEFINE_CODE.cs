using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;
namespace TB.Models
{
    public class TBL_MS_DEFINE_CODE
    {
        [Key]
        [Column(Order = 1)]
        public string MAJOR { get; set; }
        [Key]
        [Column(Order = 1)]
        public string MINOR { get; set; }
        public string DESCRIPTION_TH { get; set; }
        public string DESCRIPTION_EN { get; set; }
        public string CODE1 { get; set; }
        public string NHSO_CODE { get; set; }
        public string FLAG { get; set; }
        public string REMARK { get; set; }
        public string SEQUENCE { get; set; }
    }
}
