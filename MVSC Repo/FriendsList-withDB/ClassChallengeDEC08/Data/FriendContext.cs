//You can use the entityFrameworkCore after installing it through NUGET manager
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using ClassChallengeDEC08.Models;

namespace ClassChallengeDEC08.Data
{
    public class FriendContext : DbContext
    {
        //This states that when you are constructing this class it calls the constructor of DbContext
        //This gets entity framework to start running and do magic to allow you to work with your Database
        public FriendContext(DbContextOptions<FriendContext> options) : base(options)
        {

        }

        public DbSet<Friend> Friends { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Adds the initial values to DB <?>
            modelBuilder.Entity<Friend>().HasData(
                new Friend() { _friendID = 1, _friendName = "Jacob", _place = "North Carolina", _BirthDay = "Unknown", _Gender = "Staff Sarnt", _NickName = "Jake" },
                new Friend() { _friendID = 2, _friendName = "Joeseph", _place = "Wisconsin", _BirthDay = "Unknown", _Gender = "Male", _NickName = "Joe" },
                new Friend() { _friendID = 3, _friendName = "Fernando", _place = "Mexico", _BirthDay = "Unknown", _Gender = "Male", _NickName = "Leon" }
            );

        }
       
    }
}
