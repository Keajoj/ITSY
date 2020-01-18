using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;


namespace ITSY.Models
{
    public class TicketViewModel
    {
        //properties
        private int TicketID { get; set; }
        private category Category { get; set; }
        private string Description { get; set; }
        private priority Priority { get; set; }
        private string OpenDate { get; set; }       // TODO: Convert to actual date type rather than string
        //public string WorkLog {get; set; }

        enum category {work, home, school};
        enum priority {critical, moderate, low};
        

            //constructor (collection)
        public TicketViewModel(IFormCollection collection)
        {
            if (collection.TryGetValue("TicketID", out Microsoft.Extensions.Primitives.StringValues ticketID))
            {
                this.TicketID = int.Parse(ticketID);
            }
            if (collection.TryGetValue("Category", out Microsoft.Extensions.Primitives.StringValues category))
            {
                this.Category = (category)Enum.Parse(typeof(category), category);
            }
            if (collection.TryGetValue("Description", out Microsoft.Extensions.Primitives.StringValues description))
            {
                this.Description = description;
            }
            if (collection.TryGetValue("Priority", out Microsoft.Extensions.Primitives.StringValues priority))
            {
                this.Priority = (priority)Enum.Parse(typeof(priority), priority);
            }
            if (collection.TryGetValue("OpenDate", out Microsoft.Extensions.Primitives.StringValues openDate))
            {
                this.OpenDate = openDate;   // TODO: parse openDate into the correct date type
            }

            //Testing purposes
            Console.WriteLine(TicketID + " " + Category + " " + Description + " " + Priority + " " + OpenDate);


            //this.ticketid =;
            //this.category =;
            //this.description =;
            //this.priority =;
            //this.opendate =;
        }
    }
}
