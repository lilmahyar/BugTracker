using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.ComponentModel.DataAnnotations;

namespace BugTracker.Models
{
    public class Bug
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [Required(ErrorMessage = "ایمیل الزامی میباشد")]
        public string Email { get; set; }
        [Required]
        public string BugTitle { get; set; }
        [Required]
        public string  BugDescription { get; set; }


        public FixPriority Priority { get; set;  }
    }
}
