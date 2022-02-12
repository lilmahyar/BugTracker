using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.ComponentModel.DataAnnotations;

namespace BugTracker.Models
{
    public class Bug
    {

        public Bug(string email , string bugTitle , string bugDescription)
        {
            Email = email;
            BugTitle = bugTitle;
            BugDescription = bugDescription; 
        }
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; private set; }
        [Required(ErrorMessage = "ایمیل الزامی میباشد")]
        public string Email { get; private  set; }
        [Required]
        public string BugTitle { get; private set; }
        [Required]
        public string  BugDescription { get; private set; }


        public FixPriority Priority { get; private set;  }
    }
}
