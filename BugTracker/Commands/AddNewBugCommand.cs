using BugTracker.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Commands
{
    public class AddNewBugCommand
    {
        [Required(ErrorMessage = "ایمیل الزامی میباشد")]
        public string Email { get; set; }
        [Required]
        public string BugTitle { get; set; }
        [Required]
        public string BugDescription { get; set; }

        public FixPriority Priority { get; set; }
    }
}
