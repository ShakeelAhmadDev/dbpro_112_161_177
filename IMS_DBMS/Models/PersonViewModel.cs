using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IMS_DBMS.Models
{
    public class PersonViewModel
    {
        public int PId { get; set; }
        public string Name { get; set; }
        public int ContactNo { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string LoginErrorMessage { get; set; }
    }
}