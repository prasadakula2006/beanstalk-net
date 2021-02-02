using System;
using System.Collections.Generic;
using beanstalk_net.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace beanstalk_net.DataAccess {
    public class AppDbContext : DbContext {
        public AppDbContext(DbContextOptions options) : base(options){
         }
    public virtual DbSet<Note> Notes { get; set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder){
        base.OnModelCreating(modelBuilder);

    var now = DateTime.UtcNow;
   
    var notes = new List<Note>() {
        new Note {
            Id = 1,
            Content = "FInish RDS setup",
            UpdatedOn = now,
            CreatedOn = now
          },
        new Note {
            Id = 2,
            Content = "FInish EC2 setup",
            UpdatedOn=now,
            CreatedOn=now
          },
          new Note {
            Id = 2,
            Content = "FInish EBS setup",
            UpdatedOn=now,
            CreatedOn=now
          }
     };
     modelBuilder.Entity<Note>().HasData(notes);
    }
 }
}