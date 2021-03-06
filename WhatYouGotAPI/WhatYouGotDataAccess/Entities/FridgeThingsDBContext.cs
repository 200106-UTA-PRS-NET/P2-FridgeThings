﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WhatYouGotDataAccess.Entities
{
    public partial class FridgeThingsDBContext : DbContext
    {
        public FridgeThingsDBContext()
        {
        }

        public FridgeThingsDBContext(DbContextOptions<FridgeThingsDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<Favorite> Favorite { get; set; }
        public virtual DbSet<Ingredient> Ingredient { get; set; }
        public virtual DbSet<Instruction> Instruction { get; set; }
        public virtual DbSet<Recipe> Recipe { get; set; }
        public virtual DbSet<Review> Review { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //intentionally left blank
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.Property(e => e.Email)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Passphrase)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Ingredient>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.RecipeId })
                    .HasName("PK__Ingredie__2DC9748C3A60F384");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ImageUrl)
                    .IsRequired()
                    .HasColumnName("ImageURL")
                    .IsUnicode(false);

                entity.Property(e => e.IngredientName)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Unit).IsUnicode(false);
            });

            modelBuilder.Entity<Instruction>(entity =>
            {
                entity.Property(e => e.StepDescription)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Recipe>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ImageUrl)
                    .IsRequired()
                    .HasColumnName("ImageURL")
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Review>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RecipeId })
                    .HasName("PK__Review__085554C748171ECA");

                entity.Property(e => e.Comment).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
