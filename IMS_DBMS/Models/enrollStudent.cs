using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IMS_DBMS.Models
{
    public class enrollStudent
    {
        public int EId { get; set; }
        public string CTitle { get; set; }
        public string SName { get; set; }
        public List<Person> PersonCollection { get; set; }
        public List<Course> CourseCollection { get; set; }
    }
}