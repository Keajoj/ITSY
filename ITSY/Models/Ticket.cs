using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ITSY.Models
{
    public class Ticket
    {
        

        public int id { get; set; }
        [Display(Name = "Subject")]
        public string subject { get; set; }
        [Display(Name = "Priority")]
        public string priority { get; set; }
        [Display(Name = "Issue Type")]
        public string issueType { get; set; }
        
        [DataType(DataType.Date)]
        [Display(Name = "Date Opened")]
        public DateTime openDate { get; set; }
        [Display(Name = "Description")]
        public string description { get; set; }
        [Display(Name = "Worklog")]
        public string worklog { get; set; }
        [Display(Name = "Status")]
        public Boolean open { get; set; }

    }
}
