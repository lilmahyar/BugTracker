using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.ComponentModel.DataAnnotations;

namespace BugTracker.Models
{
    public class User
    {
        [BsonId]
        [BsonGuidRepresentation((GuidRepresentation)BsonType.ObjectId)]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "ایمیل الزامی میباشد")]
        public string Email { get; set; }
        [Required(ErrorMessage = "نام کاربری الزامی میباشد")]
        public string UserName { get; set; }
    }
}
