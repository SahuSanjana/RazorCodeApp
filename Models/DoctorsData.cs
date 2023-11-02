using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RazorCodeApp.Models
{
    public class DoctorsData
    {
        public int Doctor_id { get; set; }
        public string Doctor_name { get; set; }
        public long Doctor_contact { get; set; }
        public string Doctor_email { get; set; }

        public List<string> DoctorList { get; set; }

        

    }
}
