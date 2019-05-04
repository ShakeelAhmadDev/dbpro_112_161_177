using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace IMS_DBMS.Models
{
    public class Addcourse
    {
        public int CId { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        public string Term { get; set; }
        public decimal Fee { get; set; }
        public int Duration { get; set; }
        [DataType(DataType.Date)]
        public System.DateTime StartTime { get; set; }
        [DataType(DataType.Date)]
        public System.DateTime EndTime { get; set; }
    }
}