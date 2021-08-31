using System;
using System.ComponentModel.DataAnnotations;

namespace gregslist.Models
{
    public class Job
    {
        public string Id { get; set; }
        [Required]

        public string Company { get; set; }
        [Required]

        public string JobTitle { get; set; }
        [Required]
        [Range(0, int.MaxValue)]

        public int Hours { get; set; }
        [Required]
        [Range(0, int.MaxValue)]

        public int Rate { get; set; }

        public string Description { get; set; }

        public Job(string company, string jobTitle, int hours, int rate, string description = "None Provided")
        {
          Company = company;
          JobTitle = jobTitle;
          Hours = hours;
          Rate = rate;
          Description = description;
          Id = Guid.NewGuid().ToString();
        }
    }
}