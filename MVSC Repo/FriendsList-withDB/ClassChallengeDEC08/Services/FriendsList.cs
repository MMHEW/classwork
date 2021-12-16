using System.Collections.Generic;
using ClassChallengeDEC08.Models;
using ClassChallengeDEC08.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ClassChallengeDEC08.Services

{
    //this is my daddy i mean butler now
    public class FriendsList : IFriendsList
    {

        private FriendContext Butler;

        public FriendsList(FriendContext db)
        {
            Butler = db;

        }

       

        public List<Friend> GetFriends()
        {

            return Butler.Friends.ToList();
        }

        public Friend GetFriendById(int? id)
        {


            //creating a new friend. SingleOrDefault attempts to retrieve a friend =>(where) friend._friendID is equal to ID
            //Friend friend = this.Butler.Friends.SingleOrDefault(friend => friend._friendID == id);

            //read action
            return this.Butler.Friends.SingleOrDefault(friend => friend._friendID == id);
        }

        public void insertNewFriend(Friend friend)
        {
            //create action
            Butler.Friends.Add(friend);
            //updates the database
            Butler.SaveChanges();
        }

        public void DeleteFriendById(int? id)
        {
            ////creating a new friend. SingleOrDefault attempts to retrieve a friend =>(where) friend._friendID is equal to ID
            //Friend FriendToRemove = GetFriendById(id);

            Friend friend = (Friend)Butler.Friends.SingleOrDefault(Friends => Friends._friendID == id);
            Butler.Friends.Remove(friend);
            Butler.SaveChanges();
        }

        public void UpdateFriend(Friend friend)
        {
            Butler.Entry(friend).State = EntityState.Modified;            
            Butler.SaveChanges();
        }

    }
}
