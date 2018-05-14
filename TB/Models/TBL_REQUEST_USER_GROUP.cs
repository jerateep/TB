using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;

namespace TB.Models
{
    public class TBL_REQUEST_USER_GROUP
    {
        [Key]
        public int REQUEST_GROUP_ID { get; set; }
        public int REQUEST_ID { get; set; }
        public int GROUP_ID { get; set; }
        public string IS_VALID { get; set; }

    }
}
