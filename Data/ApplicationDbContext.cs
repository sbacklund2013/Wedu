using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Wedu.Models;

namespace Wedu.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        //Tables
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<ForumPost> ForumPosts { get; set; }
        public DbSet<Interest> Interests { get; set; }  
        public DbSet<Lecture> Lectures { get; set; }
        public DbSet<Content> Contents { get; set; }

        //Relationships
        public DbSet<Subscriber> Subscribers { get; set; }
        public DbSet<Vote> Votes { get; set; }
        public DbSet<InterestProfile> InterestProfiles { get; set; }
        public DbSet<Author> Authors { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Profile
            //Subscriptions
            modelBuilder.Entity<Subscriber>()
                .HasKey(bc => new { bc.ProfileId, bc.TopicId });
            modelBuilder.Entity<Subscriber>()
                .HasOne(bc => bc.Profile)
                .WithMany(b => b.Subscriptions)
                .HasForeignKey(bc => bc.ProfileId);
            modelBuilder.Entity<Subscriber>()
                .HasOne(bc => bc.Topic)
                .WithMany(c => c.Subscribers)
                .HasForeignKey(bc => bc.TopicId);
            //Votes
            modelBuilder.Entity<Vote>()
                .HasKey(bc => new { bc.ProfileId, bc.ForumPostId });
            modelBuilder.Entity<Vote>()
                .HasOne(bc => bc.Profile)
                .WithMany(b => b.Votes)
                .HasForeignKey(bc => bc.ProfileId);
            modelBuilder.Entity<Vote>()
                .HasOne(bc => bc.ForumPost)
                .WithMany(c => c.Votes)
                .HasForeignKey(bc => bc.ForumPostId);
            //Interests
            modelBuilder.Entity<InterestProfile>()
                .HasKey(bc => new { bc.InterestId, bc.ProfileId });
            modelBuilder.Entity<InterestProfile>()
                .HasOne(bc => bc.Interest)
                .WithMany(b => b.Profiles)
                .HasForeignKey(bc => bc.InterestId);
            modelBuilder.Entity<InterestProfile>()
                .HasOne(bc => bc.Profile)
                .WithMany(c => c.Interests)
                .HasForeignKey(bc => bc.ProfileId);
            //Authorships
            modelBuilder.Entity<Author>()
                .HasKey(bc => new { bc.ProfileId, bc.TopicId });
            modelBuilder.Entity<Author>()
                .HasOne(bc => bc.Profile)
                .WithMany(b => b.Authorships)
                .HasForeignKey(bc => bc.ProfileId);
            modelBuilder.Entity<Author>()
                .HasOne(bc => bc.Topic)
                .WithMany(c => c.Authors)
                .HasForeignKey(bc => bc.TopicId);
            base.OnModelCreating(modelBuilder);
        }

    }
}
