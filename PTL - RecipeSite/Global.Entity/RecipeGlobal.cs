using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Global.Entity
{
    public class RecipeGlobal
    {
        public int RecipeId { get; set; }

        public int? UserId { get; set; }

        public string Title { get; set; } = null!;

        public string? Instructions { get; set; }

        //public virtual User? User { get; set; }
    }
}
