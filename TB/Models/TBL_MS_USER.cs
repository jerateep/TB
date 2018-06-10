using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;

namespace TB.Models
{
    public class TBL_MS_USER
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int USER_ID { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public string TITLE_ID { get; set; }
        public string FNAME { get; set; }
        public string LNAME { get; set; }
        public string GENDER { get; set; }
        public string IDCARD { get; set; }
        public string BORN { get; set; }
        public string ADDRESS { get; set; }
        public string MOO { get; set; }
        public string SITE_ID { get; set; }
        public string PHONE { get; set; }
        public string EMAIL { get; set; }
        public string ORG_ID { get; set; }
        public string USERLEVEL { get; set; }
        public string STATUS { get; set; }
        public string REGIS_DATE { get; set; }
        public string LAST_DATE { get; set; }
        public string IS_DELETED { get; set; }
        public int CREATE_BY { get; set; }
        public DateTime CREATED_DATE { get; set; }
        public int UPDATE_BY { get; set; }
        public DateTime UPDATED_DATE { get; set; }

    }
}
