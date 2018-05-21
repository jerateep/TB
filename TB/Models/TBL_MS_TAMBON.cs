using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;
namespace TB.Models
{
    public class TBL_MS_TAMBON
    {
        private float _LATITUDE, _LONGTITUDE;
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string TAMBON_ID { get; set; }
        public string AMPUR_ID { get; set; }
        public string TAMBON_NAME_TH { get; set; }
        public string TAMBON_NAME_EN { get; set; }
        public float LATITUDE
        {
            get { return _LATITUDE; }
            set { _LATITUDE = value; }
        }
        public float LONGTITUDE
        {
            get { return _LONGTITUDE; }
            set { _LONGTITUDE = value; }
        }
        [Column(TypeName = "text")]
        public string POLYGON { get; set; }
        public string STATUS { get; set; }

    }
}
