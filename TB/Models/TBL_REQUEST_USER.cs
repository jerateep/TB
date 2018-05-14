using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;

namespace TB.Models
{
    public class TBL_REQUEST_USER
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int REQUEST_ID { get; set; }
        public string TITLE_ID { get; set; }
        public string FNAME { get; set; }
        public string LNAME { get; set; }
        public string PHONE { get; set; }
        public string EMAIL { get; set; }
        public string CID { get; set; }
        public string ORG_ID { get; set; }
        public string REQUEST_DATE { get; set; }
        public string REQUEST_STATUS { get; set; }
        public string REGIS_BY { get; set; }
        public string REGIS_DATE { get; set; }
        public DateTime CREATED_DATE { get; set; }
        public DateTime UPDATED_DATE { get; set; }

    }
}
