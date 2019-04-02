﻿using Microsoft.EntityFrameworkCore;
using Thread_.NET.DAL.Entities;

namespace Thread_.NET.DAL.Context
{
    public class ThreadContext : DbContext
    {
        public ThreadContext(DbContextOptions<ThreadContext> options) : base(options) { }

        public DbSet<Comment> Comments { get; set; }
        public DbSet<CommentReaction> CommentReactions { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostReaction> PostReactions { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Setting up entities using extension method
            modelBuilder.Configure();

            // Seeding data using extension method
            /* NOTE: this method will be called every time after adding a new migration.
            / We comment on this because we use Bogus for generating data and we don't need to generate new data every time. */
            // modelBuilder.Seed();
        }
    }
}