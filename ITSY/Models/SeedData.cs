using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ITSY.Data;
using System;
using System.Linq;

namespace ITSY.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ITSYContext(serviceProvider.GetRequiredService<DbContextOptions<ITSYContext>>()))
            {
                // Look for any tickets.
                if (context.Ticket.Any())
                {
                    return; // DB has been seeded, do nothing
                }

                context.Ticket.AddRange(
                    new Ticket
                    {
                        subject = "UI Glitch",
                        priority = "Low",
                        issueType = "Bug",
                        openDate = DateTime.Parse("2020-1-21"),
                        description = "The UI sometimes doesn't look right.",
                        worklog = "Ticket created by JThomas.",
                        open = true
                    },
                    new Ticket
                    {
                        subject = "Incorrect Date/Time",
                        priority = "Medium",
                        issueType = "Bug",
                        openDate = DateTime.Parse("2020-1-22"),
                        description = "Date and Time showing dates far into the cosmic future.",
                        worklog = "Ticket created by MMendez.",
                        open = true
                    },
                    new Ticket
                    {
                        subject = "Out of Dog Food",
                        priority = "High",
                        issueType = "Bug",
                        openDate = DateTime.Parse("2020-1-23"),
                        description = "help i am completely out of food i haven't eaten in MINUTES please help me",
                        worklog = "Ticket created by OMendez.",
                        open = true
                    },
                    new Ticket
                    {
                        subject = "Database Removal",
                        priority = "Critical",
                        issueType = "Bug",
                        openDate = DateTime.Parse("2020-1-24"),
                        description = "The entire database has been deleted. God help us.",
                        worklog = "Ticket created by CWinchester.",
                        open = true
                    }
                );
                context.SaveChanges();
            }
        }
    }
}