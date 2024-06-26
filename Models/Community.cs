﻿using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Reddit.Models
{
    public class Community
    {
        [Key]
        public int Id { get; set; }
        User Owner { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public virtual ICollection<Post> Posts { get; set; }
        public virtual ICollection<User> Subscribers { get; set; }
    }
}
