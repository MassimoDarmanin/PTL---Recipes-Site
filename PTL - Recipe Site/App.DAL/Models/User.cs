using System;
using System.Collections.Generic;

namespace App.DAL.Models
{
    public partial class User
    {
        public User()
        {
            Recipes = new HashSet<Recipe>();
        }

        public int UserId { get; set; }
        public string Username { get; set; } = null!;
        public string Email { get; set; } = null!;
        public DateTime? CreatedDate { get; set; }

        public virtual ICollection<Recipe> Recipes { get; set; }
    }
}
