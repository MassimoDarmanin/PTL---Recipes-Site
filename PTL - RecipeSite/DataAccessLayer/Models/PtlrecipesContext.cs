using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Models;

public partial class PtlrecipesContext : DbContext
{
    public PtlrecipesContext()
    {
    }

    public PtlrecipesContext(DbContextOptions<PtlrecipesContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Recipe> Recipes { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        => optionsBuilder.UseSqlServer();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Recipe>(entity =>
        {
            entity.HasKey(e => e.RecipeId).HasName("PK__recipes__3571ED9B64D06BE9");

            entity.ToTable("recipes");

            entity.Property(e => e.RecipeId)
                .ValueGeneratedNever()
                .HasColumnName("recipe_id");
            entity.Property(e => e.Instructions)
                .HasColumnType("text")
                .HasColumnName("instructions");
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("title");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.User).WithMany(p => p.Recipes)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__recipes__user_id__398D8EEE");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__users__B9BE370FECF0DE7D");

            entity.ToTable("users");

            entity.Property(e => e.UserId)
                .ValueGeneratedNever()
                .HasColumnName("user_id");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("username");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
