using System;
using System.Collections.Generic;

namespace DataAccessLayer.Models;

public partial class Recipe
{
    public int RecipeId { get; set; }

    public int? UserId { get; set; }

    public string Title { get; set; } = null!;

    public string? Instructions { get; set; }

    public virtual User? User { get; set; }
}
